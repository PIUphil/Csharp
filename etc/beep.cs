using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep(512, 300);
            Beep(640, 300);
            Beep(768, 300);

            // 도              = 256.0Hz
            // 레 = 도 *  9/8  = 288.0Hz
            // 미 = 레 * 10/9  = 320.0Hz
            // 파 = 미 * 16/15 = 341.3Hz
            // 솔 = 파 *  9/8  = 384.0Hz
            // 라 = 솔 * 10/9  = 426.6Hz
            // 시 = 라 *  9/8  = 480.0Hz
            // 도 = 시 * 16/15 = 512.9Hz ※ 처음 도의 2배
            // 2배 = 높은음, 1/2배 = 낮은음
        }

        /// <summary>
        /// 비프음 발생하기
        /// </summary>
        /// <param name="frequency">주파수</param>
        /// <param name="duration">시간(단위 : 1/1000초)</param>
        [DllImport("kernel32")]
        public static extern void Beep(int frequency, int duration);

    }
}

// 출처 : https://icodebroker.tistory.com/entry/CCOMMON-Beep-%EC%9D%8C-%EB%B0%9C%EC%83%9D%EC%8B%9C%ED%82%A4%EA%B8%B0
