<template>
  <div>
    用户名: <input type="text" v-model="state.loginData.userName">
    密码：<input type="password" v-model="state.loginData.password">
    <input type="submit" value="登录" @click="loginSubmit">
    
    <!-- 调试信息 -->
    <div v-if="state.debugInfo" style="color: red; margin-top: 20px;">
      调试信息: {{ state.debugInfo }}
    </div>
    
    <!-- 进程列表 -->
    <ul>
      <li v-for="p in state.processes" :key="p.id">
        {{ p.id }} {{ p.name }} {{ p.workingSet }}
      </li>
    </ul>
  </div>
</template>

<script>
import axios from 'axios';
import { reactive, onMounted } from 'vue';

export default {
  name: 'Login',
  setup() {
    const state = reactive({
      loginData: {
        userName: '',
        password: ''
      },
      processes: [],
      debugInfo: ''
    });

    const loginSubmit = async () => {
      try {
        state.debugInfo = '正在发送请求...';
        
        const payload = state.loginData;
        console.log('发送的数据:', payload);
        
        const resp = await axios.post('https://localhost:7125/Login/Login', payload);
        const data = resp.data;
        
        console.log('后端返回的数据:', data);
        state.debugInfo = `响应状态: ${resp.status}, 登录结果: ${data.ok}`;
        
        // 修正：使用 data.ok 而不是 data.isOK
        if (!data.ok) {
          alert("登陆失败");
          return;
        }
        
        alert("登录成功");
        
        // 修正：使用正确的字段名
        state.processes = data.processInfos;
        
      } catch (error) {
        console.error('登录请求失败:', error);
        state.debugInfo = `请求失败: ${error.message}`;
        
        if (error.response) {
          state.debugInfo += `, 状态码: ${error.response.status}`;
        }
        alert("登录请求失败");
      }
    };

    onMounted(async () => {
      try {
        // 如果你还想在页面加载时获取进程列表，保留这个
        const response = await axios.get('/api/processes');
        state.processes = response.data;
      } catch (error) {
        console.error('Failed to fetch processes:', error);
      }
    });

    return {
      state,
      loginSubmit
    };
  }
}
</script>

<style scoped>
div {
  padding: 20px;
}
input {
  margin: 5px;
  padding: 8px;
  display: block;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  padding: 5px;
  border-bottom: 1px solid #ccc;
  font-family: monospace;
}
</style>