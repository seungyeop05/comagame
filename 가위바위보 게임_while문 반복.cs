namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n == 0)
            {
                Random rand = new Random();
                int AI = rand.Next(0, 3);
                Console.WriteLine("무엇을 낼 지 정하세요 (0 = 가위,1 = 주먹, 2 = 보)");
                int Player = Convert.ToInt32(Console.ReadLine());

                switch (Player)
                {
                    case 0:
                        Console.WriteLine("플레이어 : 가위");
                        break;
                    case 1:
                        Console.WriteLine("플레이어 : 주먹");
                        break;
                    case 2:
                        Console.WriteLine("플레이어 : 보");
                        break;
                }

                switch (AI)
                {
                    case 0:
                        Console.WriteLine("상대 : 가위");
                        break;
                    case 1:
                        Console.WriteLine("상대 : 주먹");
                        break;
                    case 2:
                        Console.WriteLine("상대 : 보");
                        break;
                }

                if (Player == 0)
                {
                    if (AI == 0)
                        Console.WriteLine("무승부입니다.");
                    else if (AI == 1)
                        Console.WriteLine("졌습니다.");
                    else
                        Console.WriteLine("이겼습니다.");
                }
                else if (Player == 1)
                {
                    if (AI == 0)
                        Console.WriteLine("이겼습니다.");
                    else if (AI == 1)
                        Console.WriteLine("무승부입니다.");
                    else
                        Console.WriteLine("졌습니다.");
                }
                else if (Player == 2)
                {
                    if (AI == 0)
                        Console.WriteLine("졌습니다.");
                    else if (AI == 1)
                        Console.WriteLine("이겼습니다.");
                    else
                        Console.WriteLine("무승부입니다.");
                }
                else
                    break;
            }
            
            

        }
    }
}