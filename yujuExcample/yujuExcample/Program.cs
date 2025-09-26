using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yujuExcample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int score = Convert.ToInt32(Console.ReadLine());
            Level myLevel =Level.high;
            switch (myLevel)
            {
                case Level.low:
                    Console.WriteLine("trash");
                    break;
                case Level.mid:
                    Console.WriteLine("normal");
                    break;
                case Level.high:
                    Console.WriteLine("highlevel");
                    break;
                default:
                    break;
            }

        }
        enum Level
        { 
         low, mid, high
        }
    }
}
//switch (score/10)
            //{
            //    case 1:
            //        case 2:
            //          case 3:
            //              case 4:  
            //                  case 5:
            //                      case 6:
            //        Console.WriteLine("不及格");
            //        break;
            //        case 7:
            //            case 8:
            //        Console.WriteLine("良好");
            //        break;
            //                case 9:
            //                    case 10:
            //        if (score ==100)
            //        {
            //            Console.WriteLine("满分");
            //        }
            //        else goto default;
            //        Console.WriteLine("优秀");
            //        break;
                    

            //    default:
            //        Console.WriteLine("无效的值");
            //        break;
            //}