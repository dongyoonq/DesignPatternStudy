using System;

namespace DesignPatternStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Memento Pattern */
            /****************************************************************************************************/
            /*
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

            /* Singletone Pattern */
            // Singleton singleton = new Singleton(); : 외부에 생성하지 못하도록 Private로 설정해서 불가능
            Singleton.GetInstance();
            // 단 하나의 객체 인스턴스에 접근하기 위해 메서드로 접근가능.
            Singleton.GetInstance().Start();
            // 인스턴스에 접근해 그 클래스의 메서드를 호출 시키는 방식
        }
    }
}
