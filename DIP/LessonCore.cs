using System;

namespace DIP
{

    public interface IExtend
    {
        void Show();
    }
    
    /// <summary>
    /// 抽象类：包含不确定元素
    /// </summary>
    public abstract class LessonBase
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        /// <summary>
        /// 不同子类的实现不一样,使用抽象方法
        /// </summary>
        public abstract void Study();
        /*{
            Console.WriteLine("学习.NET高级课程");
        }*/

        public void Movie()
        {
            Console.WriteLine("可以获取视频回看");
        }
    }
    
    /// <summary>
    /// 核心语法公开课
    ///
    /// 类里面的元素都是确定的
    /// </summary>
    public class LessonCore:LessonBase
    {
        /*public int Id { get; set; }
        
        public string Name { get; set; }*/

        public override void Study()
        {
            Console.WriteLine("学习.NET高级课程");
        }

        /*public void Movie()
        {
            Console.WriteLine("可以获取视频回看");
        }*/
    }
    
    /// <summary>
    ///
    /// 设计模式公开课
    /// 
    /// </summary>
    public class LessonDesign:LessonBase,IExtend
    {
        /*public int Id { get; set; }
        
        public string Name { get; set; }*/
        
        /// <summary>
        /// 重写方法
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("学习.NET高级课程的设计模式");
        }

        /*public void Movie()
        {
            Console.WriteLine("可以获取视频回看");
        }*/
        public void Show()
        {
            Console.WriteLine("test data");
        }
    }
}