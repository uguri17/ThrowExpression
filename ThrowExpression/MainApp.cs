using System;

namespace ThrowExpression
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                int? a = null; // 원래 값 형식은 null이 안되지만 '?' 연산자를 기입함으로써 a는 값 형식임에도 불구하고 null을 허용한다
                int b = a ?? throw new ArgumentNullException(); // '??' 기준 왼쪽 값(여기서는 a)이 null이면 오른쪽 리턴 // 반대로 null이 아니라면 왼쪽 리턴
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();

            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
            }                            // 조건           // 참     // 거짓
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }                        
        }
    }
}
