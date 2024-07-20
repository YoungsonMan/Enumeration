/**************************************************************************
 * 열거형 과제
 * 최연승
 * 과제 1. 열거형 리팩토링
 * 과제 2. 상태를 열거형으로 구현
 **************************************************************************/

namespace EnumAssignment
{
    internal class Program
    {
        enum Place { village = 1, field, market }
        enum Status { idle = 1, run, walk, dead = 9 }
        static void Main(string[] args)
        {

            // 과제 1. 열거형 리팩토링
            // 기존 코드를 열거형을 활용하여 가독성 올리기.
            string[] lines = new string[3]
            {
                "마을로 이동합니다.", "사냥터로 이동합니다.", "상점으로 이동합니다."
            };
            Console.WriteLine("이동할 장소를 설정해 주세요");
            Console.WriteLine("소문자로 기입하세요 / 그냥 숫자를 기입해도됩니다.");
            Console.WriteLine("1. village\t 2. field\t 3. market");
            int selectedNumber;
            Place place;
            Enum.TryParse(Console.ReadLine(), out place);
            selectedNumber = (int)place;
            Console.WriteLine($"{place}를 선택하셨습니다.");

            if (selectedNumber == 1)
            {
                Console.WriteLine(lines[0]);
            }
            else if (selectedNumber == 2)
            {
                Console.WriteLine(lines[1]);
            }
            else if (selectedNumber == 3)
            {
                Console.WriteLine(lines[2]);
            }
            Console.WriteLine("=======================================================================\n");


            // 과제 2. 상태를 열거형으로 구현
            // 플레이어의 현재 행동이 int state로 정의 되어있습니다.
            ////    string[] status = new string[(int)Status.dead];
            Status state;
            // state 변수에 1이 담겨 있으면 idle
            //              2가 담겨 있으면 run
            //              3이 담겨 있으면 walk
            //              9가 담겨 있다면 dead
            // 열거형을 활용하여 해당 코드를 어떻게 수정 할 수 있는지 작성
            // 유저에게 콘솔 입력으로 1,2,3,9 외의 입력이 들어오면, 옳지 못한 입력 출력
            // 다시 입력을 요구하기.
            Console.WriteLine("플레이어의 상태를 알려주세요");
            Console.WriteLine("1. 잠수중  2. 뛰는중  3. 걷는중  9. 죽음");
            do
            {
           /////     Console.WriteLine("플레이어의 상태를 알려주세요");
           /////     Console.WriteLine("1. 잠수  2. 뛰는중  3. 걷는중  9. 죽음");
                Enum.TryParse(Console.ReadLine(), out state);
                if ((int)state == 1 || (int)state == 2 || (int)state == 3 || (int)state == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{(int)state}를 입력하셨습니다. {state}.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("옳지 못한 입력입니다.");
                Console.WriteLine("플레이어의 상태를 알려주세요");
                Console.WriteLine("1. 잠수중  2. 뛰는중  3. 걷는중  9. 죽음");
            } while ((int)state != 1 || (int)state != 2 || (int)state != 3 || (int)state == 9);
            //Console.WriteLine($"{state}. 번호확인{(int)state}");


        }
    }
}
