using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatternStudy
{
    // Originator 클래스
    class Game
    {
        public int Level { get; set; }
        public int Health { get; set; }
        public int Score { get; set; }

        public void DisplayStatus()
        {
            Console.WriteLine($"Level: {Level}, Health: {Health}, Score: {Score}");
        }

        // Memento 객체를 생성하여 현재 상태를 저장
        public Memento SaveState()
        {
            return new Memento(Level, Health, Score);
        }

        // Memento 객체로부터 저장된 상태를 복원
        public void RestoreState(Memento memento)
        {
            Level = memento.Level;
            Health = memento.Health;
            Score = memento.Score;
        }
    }

    // Memento 클래스
    [Serializable]
    class Memento
    {
        public int Level { get; private set; }
        public int Health { get; private set; }
        public int Score { get; private set; }

        public Memento(int level, int health, int score)
        {
            Level = level;
            Health = health;
            Score = score;
        }
    }

    // Caretaker 클래스
    class SaveManager
    {
        private string filePath = "save.dat";

        // 현재 게임 상태를 저장
        public void Save(Game game)
        {
            Memento memento = game.SaveState();
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, memento);
            }
            Console.WriteLine("Game saved.");
        }

        // 저장된 게임 상태를 불러옴
        public void Load(Game game)
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Memento memento = (Memento)bf.Deserialize(fs);
                    game.RestoreState(memento);
                }
                Console.WriteLine("Game loaded.");
            }
            else
            {
                Console.WriteLine("No save file found.");
            }
        }
    }
}