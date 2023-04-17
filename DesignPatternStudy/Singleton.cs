namespace DesignPatternStudy
{
    // Singleton 으로 만든 클래스는 클래스 자신을 객체로 만들기위해 객체의 인스턴스를 단 하나만 사용(생성)하는 방식
    // 그러기 위해 자기 자신의 객체를 클래스 내부에 private로 만들어 외부에는 객체를 감추고,
    // 오로지 GetInstance 메서드로만 클래스 자기 자신의 객체를 호출시켜 접근할 수 있다.
    class Singleton
    {
        private static Singleton inst;
        public static Singleton GetInstance()
        {
            if (inst == null)
                inst = new Singleton();
            return inst;
        }
        
        private Singleton()
        {
            // 생성자는 외부에서 호출 못하게 private 으로 지정
        }

        public void Start()
        {
            System.Console.WriteLine("싱글톤 패턴 출력.");
        }
    }
}
