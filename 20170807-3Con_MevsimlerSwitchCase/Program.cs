using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170807_3Con_MevsimlerSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * switch-case : seçim listesi söz konusuysa, if e göre daha performanslı çalıştığı için tercih edilebilir. 
             */

            Console.Write("Ay Giriniz : ");
            string ay = Console.ReadLine();

            switch (ay)
            {
                case "12":
                case "1":
                case "2":
                case "ARALIK":
                case "aralık":
                case "OCAK":
                case "ocak":
                case "ŞUBAT":
                case "şubat":
                    Console.Write("Kış");
                    break;
                case "3":
                case "4":
                case "5":
                case "MART":
                case "mart":
                case "NİSAN":
                case "nisan":
                case "MAYIS":
                case "mayıs":
                    Console.Write("İlkbahar");
                    break;
                case "6":
                case "7":
                case "8":
                case "HAZİRAN":
                case "haziran":
                case "TEMMUZ":
                case "temmuz":
                case "AĞUSTOS":
                case "ağustos":
                    Console.Write("Yaz");
                    break;
                case "9":
                case "10":
                case "11":
                case "EYLÜL":
                case "eylül":
                case "EKİM":
                case "ekim":
                case "KASIM":
                case "kasım":
                    Console.Write("Yaz");
                    break;
                default:
                    Console.Write("Yanlış bir ay girdiniz");
                    break;
            }

            Console.Read();            
        }                    
    }                        
}
