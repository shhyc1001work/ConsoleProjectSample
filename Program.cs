﻿using System;
using System.Threading;

namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 100);
            string[] myMococos = new string[6];

            SetMococos(myMococos);

            while (true) //움짤 무한 반복
            {
                foreach (var a in myMococos) //이미지 반복문에 있는 
                {
                    Thread.Sleep(200); // 0.5초마다 다음 프레임 재생
                    ClearScreenByFilling();
                    Console.WriteLine(a);
                }
            }
        }

        //▼화면을 수동으로 빈칸을 채우는 코드
        static void ClearScreenByFilling()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ");
            Console.SetCursorPosition(0, 0);
        }

        //▼원하는 스트링 채워두는 코드
        static void SetMococos(string[] inputArr)
        {
            inputArr[0] = "                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                 .......                                            \r\n                                                 .:#@#+:...                                         \r\n                                              ..:#@@@@@@@%+.         ........:.....                 \r\n                                              .+@@@@%*#%@@@@%-......+%@@@@@@@@@@@@@@.               \r\n                                            ..-@@@@*=====+#@@@@+=%@@@@@@@@@@@@@@@@@@-               \r\n                                            .:#@@%==========#@@@@@@@%#+=========*@@@:               \r\n                                            .+@@@+============+#*+==============*@@@:               \r\n                                            .-@@@===============================#@@@.               \r\n                                            .-@@%+========#@@+===**=============%@@@.               \r\n                                          ....#@@%=========@@@#@@@%============*@@@*.               \r\n                                      ....-%@@@@@@@@@@@@@@@@@@@@@@%*===========%@@@:.               \r\n                                 ....:%@@@@@@@@%%%%%%%#%%%@%@@@@@@@@@@@#+=====@@@@*..               \r\n                                 ..*@@@@@#=::.:::...::::::.:.:.::-+#@@@@@@%@@@@@@*...               \r\n                               .+#@@@@*:......................:.:::.:.-*@@@@@@@=.....               \r\n                             .=@@@@+::..................................:-%@@@@=.....               \r\n                          ..:%@@@*:...:::::..:.............................-%@@@%-...               \r\n                        ...=@@@#-:.:.=%@@@@@*::..............................:%@@@+..               \r\n                        ..+@@@=::::=@@@-...*@%:...............................:*@@@#.               \r\n                        .+@@@=:::::#@@@@@%%%@%:..::::..............:-*%#+-....::#@@@*..             \r\n                        :@@@-::::::+@@@##%@@@+...#@@#%@@*..:::...:*@@@++#@%=:...:%@@@+.             \r\n                      ..#@@*::::::::-+%@%@*=:..:.-%@@@@@@@@@@%:.:+@@@%+:.+@%:....-@@@@:             \r\n                      ..@@@-:::::::::::.........::::::::*@@%-:::.+@@-%@@@@@%-:::::#@@@#..           \r\n                      .-@@@-::::::::::::........::::::::::::::::::#@@%@@@@%-::::::-@@@%..           \r\n                       =@@@-::::::::::::........::::::::::::::::::::-=+*#-:::::::::%@@@..           \r\n                      .-@@@+::::::::::::.......::::::::::::::::::....::::::::::::::*@@@:.           \r\n                      ..@@@%-:::::::::...........::::::::::::::::...:::::::::::::::+@@@+.           \r\n                    ....*@@@=::::...................::::::::::::...::::::::::::::::*@@@..           \r\n                  ..:*@@@@@@@=:.....................:::::::::::....::::::::::::::::#@@%..           \r\n                 .+@@@@@@*%@@@*.......................::::.:::........::::::::::::+@@@@@:           \r\n               ..%@@@%+:..:*@@@@-......................................::::::::::+@@@@@@@+.         \r\n               .@@@@#:......:#@@@@+:::.................................:.::::::-#@@@*:#@@@*...      \r\n             ..-@@@#:.......:.-#@@@@@%#=::.:..:..........................:::-#%@@@@-:..=@@@%..      \r\n             ..*@@@#.....=%*=:...-%@@@@@@@@@@#=::.....:.:.:.::..:.::..:=*%@@@@@@%:.....:=@@@@...    \r\n             ..-@@@#:....+@@@@+..::.:=#%@@@@@@@@@@@@@@@%%%%##%#%%@%@@@@@@@@@%#=:.........+@@@*..    \r\n               .%@@@%-:.:..*@@@::.......:.:-+#%%%@@@@@@@@@@@@@@@@@@@@@%**=:::............:@@@@-.    \r\n               .*@@@@@@@%%@@@@%::.........::-----===-:-===-=-----:::......................#@@@=.    \r\n             ..=@@@*#%@@@@@@%=:.............:--===-======-:..........................::::=%@@@=.    \r\n             ..%@%=:.........................:-=-::==::::.........................:::%@@@@@@@-..    \r\n             ...............................:--::.:=-:...:..........................#@@@+=:.....    \r\n                          ..........................:.............................:+@@@:.           \r\n                          ........................................................-@@@=..           \r\n                                                                               .....::...           \r\n                                                                                .....               \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    ";


            inputArr[1] = "                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                 .......                                            \r\n                                                 .:#@%+: .                                          \r\n                                              ..:#@@@@@@@%+.         ........:.....                 \r\n                                              .+@@@@%*#%@@@@%-......+%@@@@@@@@@@@@@@.               \r\n                                            ..-@@@@*=====+#@@@@+=%@@@@@@@@@@@@@@@@@@-               \r\n                                            .:#@@%==========#@@@@@@@%#+=========*@@@:               \r\n                                            .+@@@+============+#*+==============*@@@:               \r\n                                            .-@@@===============================#@@@.               \r\n                                            .-@@%+========#@@*===**=============%@@@.               \r\n                                          ....%@@%=========@@@#@@@%============*@@@*.               \r\n                                      ....:%@@@@@@@@@@@@@@@@@@@@@@%*===========%@@@:.               \r\n                                 ....:%@@@@@@@@%%%%%%%#%%%%@@@@@@@@@@@@*+=====%@@@*..               \r\n                                 ..*@@@@@#=::.:::.....:.::.....::-+#@@@@@@%@@@@@@*...               \r\n                               .+#@@@@*::.....................:.::.:.:-*@@@@@@@=.....               \r\n                             .=@@@%+:....................................-%@@@@-.....               \r\n                          ..:%@@@*:.....:::.:..............................-%@@@%:...               \r\n                        ...=@@@%-:...=%@@@@@*::..............................:%@@@+..               \r\n                        ..*@@@=::::=@@@-...*@%:...............................:*@@@#.               \r\n                        .+@@@=:::::#@@@@@%%%@%:..:::...............:-*%#+-.....:#@@@*..             \r\n                        :@@@-::::::+@@@#*%@@@+...#@@#%@@*:.::....:*@@@++#@%=....:%@@@+.             \r\n                      ..#@@*::::::::-+%@%@#=:...:-%@@@@@@@@@@%:.:+@@@%+:.+@%::..:-@@@@:             \r\n                      ..@@@-:::::::::::..........:::::::*@@%-:::.+@@-%@@@@@%-:::::#@@@#..           \r\n                      .-@@@-:::::::::::.........::::::::::::::::::#@@%@%@@%-::::::-@@@%..           \r\n                      .=@@@-:::::::::::........::::::::::::::::::.::-=+**-::::::::-%@@@..           \r\n                      .-@@@+:::::::::::........::::::::::::::::::....::::::::::::::*@@@:.           \r\n                      ..@@@%-:::::::.............::::::::::::::::....::::::::::::::+@@@+.           \r\n                    ....*@@@=::::...................:::::::::::::..:.::::::::::::::*@@@..           \r\n                  ..:*@@@@@@@=......................:::::::::::....::::::::::::::::#@@%..           \r\n                  +@@@@@@*%@@@*......................:.:::::.:.....:::::::::::::::+@@@@@:           \r\n               ..%@@@@+:..:*@@@@-:...................................:.::::::::::+@@@@@@@+.         \r\n               .@@@@#:......:#@@@@+:::..................................:::::::-#@@@*:#@@@*...      \r\n             ..-@@@#:........:-#@@@@@@#=:::..............................:.:-#%@@@@-:..=@@@%..      \r\n             ..*@@@#.....=@*=:...-%@@@@@@@@@@#=::::..:.....:..:.......:-*%@@@@@@%:......-@@@@...    \r\n             ..-@@@#:....+@@@@+....::=#%@@@@@@@@@@@@@@@%%%%*#%#%%@%@@@@@@@@@%#=..........+@@@*..    \r\n               .%@@@%-:.:.:*@@@:......:...:-+#%%%@@@@@@@@@@@@@@@@@@@@@%**=::::...........:@@@@-.    \r\n               .*@@@@@@@%%@@@@%:..........::-----===-:-===-=-----:::..:::.................#@@@=.    \r\n             ..=@@@*#%@@@@@@%=:.............:--===-======-:..........................::::+%@@@=.    \r\n             ..%@@=..........................:==-::==:::::.........................::%@@@@@@@-..    \r\n             ................................:-:..:=-::.:.........................::#@@@+=:.....    \r\n                          .........................................................*@@@:.           \r\n                          ............. ... ......................................-@@@-...          \r\n                                                                               .....::...           \r\n                                                                               ......               \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    ";


            inputArr[2] = "                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                   .......                                                                          \r\n                 ..........                      .......                                            \r\n                 .......... . .                  .:#@#+:                                            \r\n                 ..:-::--:.....               ..:#@@@@@@@%+.         ........:.....                 \r\n                 ..--....:-....               .+@@@@%*#%@@@@%-......+%@@@@@@@@@@@@@@.               \r\n                  ..:--....--...            ..-@@@@*=====+#@@@@+=%@@@@@@@@@@@@@@@@@@-               \r\n                  ....:-:...-:..            .:#@@%==========#@@@@@@@%#+=========*@@@:               \r\n         ..............-:...-:.             .+@@@+============+#*+==============*@@@:               \r\n        ...---------...-:...-...            .-@@@===============================#@@@.               \r\n        .-:........:-:.-...:-:..            .-@@%+========#@@*===**=============%@@@.               \r\n        .--:::-::...:-.--....:-...        ....%@@%=========@@@#@@@%============*@@@*.               \r\n         ..:....:-..:-..:--:.-:.      ....-%@@@@@@@@@@@@@@@@@@@@@%%*===========%@@@:.               \r\n    ............:-...:----:.:... ....:%@@@@@@@@%%%%%%%#%#%%@@@@@@@@@@@@*+=====%@@@*..               \r\n    .............--......:-....  ..*@@@@@#=::.:::.......:....:.::-+#@@@@@@%@@@@@@*...               \r\n    ....:------:..:---:---......+#@@@@+:......................:::::..:-*@@@@@@@-.....               \r\n    .:--.......:-:.......... .=@@@@+::...................................:%@@@@-.....               \r\n    :-:...::.....--:::-:....:%@@@*:.....::.................................-%@@@%:...               \r\n    .------::-:......:-:...=@@@#-:..:=%@@@@@*:...............................:%@@@+..               \r\n    ..........:-------....+@@@=::::=@@@-...*@%:...............................:*@@@#.               \r\n    .....................+@@@=:::::#@@@@@%%%@%:..:::................-*%#+-....:.#@@@*..             \r\n                        :@@@-::::::+@@@#*%@@@+...#@@#%@@*...:....:*@@@++#@%=....:%@@@+.             \r\n                      ..#@@*::::::::-+%@%@#=:...:-@@@@@@@@@@@%:..+@@@%+:.+@%:....-@@@@:             \r\n                      ..@@@-:::::::::::.........:-%@#+=+%@@%-:::.+@@-%@@@@@%-:::::#@@@#..           \r\n                      .-@@@-::::::::::::........::*@@%%%@@%:::::::#@@%@%@@%-::::::-@@@%..           \r\n                       =@@@-:::::::::::........::::+%@@@%+:::::::.::-=++#-:::::::::%@@@..           \r\n                      .:@@@+:::::::::::........::::::::::::::::::....::::::::::::::*@@@:.           \r\n                      ..@@@%-:::::::.............::::::::::::::::...:::::::::::::::+@@@+.           \r\n                    ....*@@@=:::....................:::::::::::::..::::::::::::::::*@@@..           \r\n                  ..:*@@@@@@@=:.....................:::::::::::......::::::::::::::#@@%..           \r\n                  +@@@@@@*%@@@*.......................:::..:.:.......:::::::::::::+@@@@@:           \r\n               ..%@@@@+:.::*@@@@-......................................::::::::::+@@@@@@@+. ..      \r\n               .@@@@#:......:%@@@@+:::...................................::::::-%@@@*:%@@@*...      \r\n             ..-@@@#:.........-#@@@@@@#=:...................................-#%@@@@-...=@@@%..      \r\n             ..*@@@#.....=@*=....-%@@@@@@@@@@#=::.:...................:=*%@@@@@@%:......=@@@@...    \r\n             ..-@@@#:....+@@@@+....::=#%@@@@@@@@@@@@@@@%%%%*#%#%%@%@@@@@@@@@%#=..........+@@@*..    \r\n               .%@@@%-:...:*@@@:..........:-+#%%%@@@@@@@@@@@@@@@@@@@@@%**=::::...........:@@@@-.    \r\n               .*@@@@@@@%%@@@@%:...........:-----====:-===-=-----::.:..:.................:#@@@=.    \r\n             ..=@@@*#%@@@@@@%=..............:--===-======-:..........................::::=%@@@=...  \r\n             ..%@@=......:...................:==-::==:::::..........................:%@@@@@@@-....  \r\n             .........................:......:-:..:=-:.::.........................:.#@@@+=:.......  \r\n                          .........................................................*@@@:.           \r\n                          ................ .......................................-@@@-...          \r\n                                                                           .  ......::...           \r\n                                                                               ......               \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    ";


            inputArr[3] = "                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                 ........ .                                                                         \r\n                  .........                        .....::..                                        \r\n                  ...:---...                       .-#%@@@@-                                        \r\n                  ..--..:-.                      .=@@@@@@@@@#..                                     \r\n                  ..-:..::..                  ...%@@@%+==#@@@@.......=#@#%%%@#@#+:.....             \r\n        ............-:..-:......              ..%@@@#=====+%@@@=-#@@@@@@@@@@@@@@@@@@@+.             \r\n        ....----....-:..-:.....             ...%@@@*========#@@@@@@@@@%#*+++++*#%@@@@*.             \r\n         ..--..:-...--...::--:...           ..=@@@#==========*@@%+===============+@@@-.             \r\n         ..-:..:-....--......:-.....        ..*@@%+==============================@@@@..             \r\n         ..:-...--.....----:..:-....         .@@@@========%@#====+==============%@@@-               \r\n         ...--...:::::--:.:-..-:....      ....#@@@*=======#@@%%@@@%============#@@@#.               \r\n        .....--........:--.----...........#@@@@@@@@@@@@@@@@@@@@@@%#===========@@@@#..               \r\n    ..........:-------...--..........=@@@@@@@@%#%%%%%%%%%%%@@@@@@@@@@@%+===*%@@@@*...               \r\n    .................-:..--....  .=%@@@@%+::..::........::.....::=*%@@@@@@@@@@@%:...                \r\n    .:-::-:.....:---------......=@@@@%-:......................::.::..:+%@@@@@@:.....                \r\n    .-:...:-----......:-.... .%@@@#-.....................................*@@@@*......               \r\n    ..--:.........:--::-....*@@@%=.....:::................................:*@@@@*....               \r\n    ....---:...:--.........@@@%+:::.:#@@@@@%-............................:..:*@@@%...               \r\n    .......::-::....... .:@@@#:::::#@@#....@@+................................-@@@@:.               \r\n    ................... :@@@*:::::=@@@@@@%#@@+:..::................:=#%*=:.....=@@@@:               \r\n                      ..#@@+::::::-%@@%*%@@@#::.=@@%#@@%-.:.:....-%@@#=*@@*:....+@@@%..             \r\n                      .-@@%-:::::::-=#@%@%*:....:%@@@@@@@@@@@-..-%@@@#-..%@+..:.:#@@@*.             \r\n                      .#@@%::::::::::::........:*@%+++=*@@@*:::::%@*+@@@@@@*:::::-@@@@..            \r\n                      .#@@*::::::::::::.........#@%+++++%@*::::::-@@@@@@@@*:::::::#@@@+..           \r\n                      .%@@#:::::::::::.........:%@#++++*@@-:::::.:::==*#+-::::::::=@@@#..           \r\n                      .#@@%:::::::::::.........-%@#++++@@#:::::::...::::::::::::::-@@@#..           \r\n                      .*@@@=:::::::............-%@*+++@@#::::::::::.:::::::::::::::%@@%..           \r\n                    ...-@@@%::::..............::@@%##@@*::::::::....::::::::::::::-%@@# .           \r\n                  ..=%@@@@@@#:.................:-%@@@%+::::::::...::.:::::::::::::=@@@+..           \r\n                  %@@@@@%*@@@%-...................::..::::::......:..::::::::::::-#@@@@#.           \r\n               .-@@@@#-:..-@@@@*:.....................................::::::::::-%@@@@@@@.. ..      \r\n             ..=@@@@-......:+@@@@#-:...................................:::::::-*%@@@-+@@@@: ..      \r\n             ..%@@@=.........:+%@@@@@#*-:..................................:+%@@@@*:..:%@@@*..      \r\n             .-@@@@-....:#%#:.:.:#@@@@@@@@@@%*::::...:..........:.:..:-=*@@@@@@@+.......%@@@..      \r\n             ..%@@@-:...-%@@@%:...::-*#%@@@@@@@@@@@@@@@%%#####%%%@@@@@@@@@@@#+:.........:%@@@:..    \r\n             ..-@@@@*:..:.-%@@*..........::=*#%%@@@@@@@@@@@@@@@@@@@@@@#*+::.:............*@@@#..    \r\n             ..:@@@@@@@%%@@@@@+............-=---====-:===-=------:::.....................=@@@@..    \r\n             ..@@@%+%@@@@@@%+-:.............:-===--======:...........................:::-#@@@@....  \r\n             .+@@*:.........................:-==-:-=-::::...........................*@@@@@@@#.. ..  \r\n             ...............................:--:..-=:..............................=@@@%=-:.... ..  \r\n                          .........................:..............................-%@@#..           \r\n                      ...........................................................:%@@#...           \r\n                                                                           .........-..             \r\n                                                                              .......               \r\n                                                                                  .                 \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    ";



            inputArr[4] = "                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                   ........                                                                         \r\n                 ..........                      .......                                            \r\n                 ..........                      .:#@#+:                                            \r\n                 ..:-::-...                   ..:#@@@@@@@%+.         ........:.....                 \r\n                  .-:..-:...                  .+@@@@%*#%@@@@%-......+%@@@@@@@@@@@@@@.               \r\n         ..........-:..---::....            ..-@@@@*=====+#@@@@+=%@@@@@@@@@@@@@@@@@@-               \r\n         ..........--......:-:..            .:#@@%==========#@@@@@@@%#+=========*@@@:               \r\n        ..:-=-.......:---:...--. .          .+@@@+============+#*+==============*@@@:               \r\n        .:-:.:--.........:-..:-.....        .-@@@===============================#@@@.               \r\n        ..:-...:::::--....-..:-.....        .-@@%+========#@@*===**=============%@@@.               \r\n        ...:-:.......:--..--..:-....      ....%@@%=========@@@#@@@%============*@@@#.               \r\n         ....:-----:...-:..:---.....  ....-%@@@@@@@@@@@@@@@@@@@@@%%*===========%@@@:.               \r\n    ...............-:...--...........:%@@@@@@@@%%%%%%%#%#%%@@@@@@@@@@@@*+=====%@@@*..               \r\n    ................--:..-:.     ..*@@@@@#=::..::.......:....:.::-+#@@@@@@%@@@@@@*...               \r\n    .:---:.:--::--:....::...   .+#@@@@+::.....................:::::..:-*@@@@@@@-.....               \r\n    .-:..::........----..... .=@@@@+:....................................:%@@@@-.....               \r\n    ..--:...:----.....:-....:%@@@*:.....:::...:............................-%@@@%:...               \r\n    ....:---:....:-----:...=@@@%-::.:=%@@@@@*:...............................:%@@@+..               \r\n    ......................+@@@=::::=@@@-...*@%:...............................:*@@@#.               \r\n    .....................+@@@=:::::#@@@@@%%%@%:..:::................-*%#+-:...:.#@@@*..             \r\n                        :@@@-::::::+@@@#*%@@@+...#@@#%@@*...:....:*@@@++#@%=....:%@@@+.             \r\n                      ..#@@*::::::::-+%@%@#=:...:*@@@@@@@@@@@%:..+@@@%+:.+@%:::..-@@@@:             \r\n                      ..@@@-:::::::::::.........=%@%++=+#@@@#:::.+@@-%@@@@@%-:::::#@@@#..           \r\n                      .-@@@-:::::::::::.........#@@++++++#@@-:::::#@@%@@@@%-::::::-@@@%..           \r\n                       =@@@-:::::::::::........:%@#++++++@@*:::::.:.-=++#-:::::::::%@@@..           \r\n                      .:@@@+:::::::::::........-@@*+++++%@@::::::...:::::::::::::::*@@@:.           \r\n                      ..@@@%-:::::::...........=@@+++++%@@-::::::....::::::::::::::+@@@+.           \r\n                    ....*@@@=:::...............=@@*++*%@%-:::::::....::::::::::::::*@@@..           \r\n                  ..:*@@@@@@@=:................:#@@@@@@#:::::::......::::::::::::::#@@%..           \r\n                  +@@@@@@*%@@@*................::+*@%+::::..::.:.....:::::::::::::+@@@@@:           \r\n               ..%@@@@+:.::*@@@@-:.................::..................::::::::::+@@@@@@@+. ..      \r\n               .@@@@#:......:%@@@@+:::...................................::::::-%@@@*:%@@@*...      \r\n             ..-@@@#:.........-#@@@@@@#=:...................................-#%@@@@-...=@@@%..      \r\n             ..*@@@#.....=@*=....-%@@@@@@@@@@#=::.:...................:=*%@@@@@@%:......=@@@@...    \r\n             ..-@@@#:....+@@@@+....::=#%@@@@@@@@@@@@@@@%%%%*#%#%%@%@@@@@@@@@%#=..........+@@@*..    \r\n               .%@@@%-:...:*@@@::.........:-+#%%%@@@@@@@@@@@@@@@@@@@@@%**=::::...........:@@@@-.    \r\n               .*@@@@@@@%%@@@@%:...........:-----====:-===-=-----::.:..:..................#@@@=.    \r\n             ..=@@@*#%@@@@@@%=..............:--===-======-:..........................::::=%@@@=...  \r\n             ..%@@=......:...................:==-::==:::::..........................:%@@@@@@@-....  \r\n             .........................:......:-:..:=-:.::.........................:.#@@@+=:.......  \r\n                          .........................................................*@@@:.           \r\n                          ................ .......................................-@@@-...          \r\n                                                                           .  ......::...           \r\n                                                                               ......               \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    ";



            inputArr[5] = "                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                 .. ........                                                                        \r\n                  .........                        .....:-..                                        \r\n                 ....:---...                       ..+%@@@@#                                        \r\n                 ...:-..--..                     ..%@@@@@@@@@+.               ..                    \r\n                 ...--..-:..                     =@@@@*===%@@@#.. ...-+@##@%#@%@++:....             \r\n         ...........-:..-:.....               ..-@@@%+=====#@@@@-=@@@@@@@@@@@@@@@@@@@%.             \r\n         ...----....-:..-:......              .:@@@%========+@@@@@@@@@@%**++++**#%@@@@.             \r\n         ..-:..:-...--...::--:.....           .%@@@===========%@@#================@@@#.             \r\n         ..-:..:-....--:.....:-.....          .@@@#==============================*@@@*.             \r\n         ..:-...--.....:----..:-....        ..:@@@#=======+@@+===++=============+@@@%..             \r\n         ...--....::::--:.:-..-:....      ....:@@@%========%@@#%@@@*============@@@@-               \r\n        .....--.........--.:---.....  ....-%@@@@@@@@@@@@@@@@@@@@@%%*==========#@@@@:.               \r\n    ..........:-------...--..........:%@@@@@@@@%%%%%%%#%%%%@@@@@@@@@@@@*+==+#@@@@@:..               \r\n    .................-:..--....  ..*@@@@@#=::.:::....:..:......::-+#@@@@@@@@@@@@+....               \r\n    .:-:--:.....:---------......+#@@@@+:.......................::.::.:-*@@@@@@+......               \r\n    .-:...:-----......:-.... .=@@@@+:..................................:.:%@@@@-.....               \r\n    ..--:.........:--::-....:%@@@*:....:::::..:............................-%@@@%-...               \r\n    ....---....:--.........=@@@#-:..:=%@@@@@*:...............................:%@@@+..               \r\n    .......::-::....    ..+@@@=::::=@@@-...*@%:...............................:*@@@#.               \r\n    ..............      .+@@@=:::::#@@@@@%%%@%:..:::................-*%#+-....:.#@@@*..             \r\n                        :@@@-::::::+@@@#*%@@@+...#@@#%@@*:.::....:*@@@++#@%=:...:%@@@+.             \r\n                      ..#@@*::::::::-+%@%@#=:..:.*@@@@@@@@@@@%:..+@@@%+:.+@%::...-@@@@:             \r\n                      ..@@@-::::::::::::........=%@%++++#@@@#::::+@@-%@@@@@%-:::::#@@@#..           \r\n                      .-@@@-:::::::::::.........#@@++++++#@@-:::::#@@%@@@@%-::::::-@@@%..           \r\n                      .=@@@-:::::::::::........:%@#++++++@@*:::::.:::=++#-:::::::::%@@@..           \r\n                      .-@@@+::::::::::.........-@@*+++++%@@::::::....::::::::::::::*@@@:.           \r\n                      ..@@@%-:::::::...........=@@+++++%@@-::::::::..::::::::::::::+@@@+.           \r\n                    ....*@@@=::::..............=@@#++*%@%-:::::::....::::::::::::::*@@@..           \r\n                  ..:*@@@@@@@=.:...............:#@@@@@@#:::::::......::::::::::::::%@@%..           \r\n                  +@@@@@@*%@@@*................::+*@%+:.:::.:........:::::::::::::+@@@@@:           \r\n               ..%@@@@+:..:*@@@%-................::.:................:.::::::::::+@@@@@@@+.         \r\n               .@@@@#::.....:#@@@@+::...................................:::::::-%@@@*:#@@@*...      \r\n             ..-@@@#:.........-*@@@@@@#=:....::............................:-#%@@@@-...=@@@%..      \r\n             ..*@@@#.....=@*=....-%@@@@@@@@@@#=::.:.........:.:...:...:-*%@@@@@@%:......-@@@@...    \r\n             ..-@@@#:....+@@@@+.:..::=##@@@@@@@@@@@@@@@@%%%##%#%%@%@@@@@@@@@%#=..........+@@@*..    \r\n               .%@@@%-:..::*@@@:..........:-+#%%%@@@@@@@@@@@@@@@@@@@@@%**=::::...........:@@@@-.    \r\n               .*@@@@@@@%%@@@@%:..........::-----===-:-===-=-----::::...:................:#@@@=.    \r\n             ..=@@@*#%@@@@@@%=:.............:--===-======-:.........................:::::+%@@@=.    \r\n             ..%@@=.........................::==-::==::::...........................:%@@@@@@@-..    \r\n             .........................:......:-:..:=-:...:........................:.#@@@+=:.....    \r\n                          .........................................................*@@@:.           \r\n                             .....................................................-@@@-...          \r\n                                                                               .....::...           \r\n                                                                                .....               \r\n                                                                                   .                \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    ";

        }
    }
}