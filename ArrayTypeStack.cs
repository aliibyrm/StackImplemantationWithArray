using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ArrayTypeStack : IStack
    {
        private object [] items;
        private int top = -1;

        public int Top {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }



        }

        public ArrayTypeStack()
        {
      
        }

        public ArrayTypeStack(int itemCount)
        {
            this.items = new object[itemCount];
        }

        public int GetTop()
        {
            return top;

        }

        public void SetTop(int value)
        {
            top = value;
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public object Peek()
        {
           return items [Top];
        }

        public object Pop()
        {
            if (IsEmpty())
            {

                throw new Exception("Hata: Stack Boş...(Owerflow)");
            }
            Object temp = items[top--];
            return temp;
        }

        public void Push(object item)
        {
            if(items.Length==top+1)
            {
                throw new Exception("Hata: Stack Dolu...(Owerflow)");
            }
            items[++top] = item;
            
        }
    }
}
