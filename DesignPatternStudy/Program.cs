using System;

namespace DesignPatternStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Memento Pattern */
            /****************************************************************************************************/
            // 게임 시작
            Game game = new Game();
            game.Level = 1;
            game.Health = 100;
            game.Score = 0;

            // 저장 매니저 생성
            SaveManager saveManager = new SaveManager();

            // 게임 상태 저장
            saveManager.Save(game);

            // 게임 상태 변경
            game.Level = 2;
            game.Health = 50;
            game.Score = 100;

            game.DisplayStatus(); // Level: 2, Health: 50, Score: 100

            // 게임 상태 복원
            saveManager.Load(game);

            game.DisplayStatus(); // Level: 1, Health: 100, Score: 0
            /****************************************************************************************************/
        }
    }
}
