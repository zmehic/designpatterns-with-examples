﻿namespace DesignPatterns.Iterator
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new InvalidOperationException();
        }

        public virtual string GetName()
        {
            throw new InvalidOperationException();
        }

        public virtual string GetDescription()
        {
            throw new InvalidOperationException();
        }

        public virtual double GetPrice()
        {
            throw new InvalidOperationException();
        }

        public virtual bool IsOneDayJob()
        {
            throw new InvalidOperationException();
        }

        public virtual void Print()
        {
            throw new InvalidOperationException();
        }
    }
}
