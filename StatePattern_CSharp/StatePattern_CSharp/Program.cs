using System;

namespace StatePattern_CSharp.DesignPatterns.State.Conceptual
{
    class Context
    {

        private State _state = null;
        public Context(State state)
        {
            this.TransitionTo(state);
        }


        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }


        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }


    abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }

    class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA manejar solicitud1.");
            Console.WriteLine("ConcreteStateA quiere cambiar el estado del contexto.");
            this._context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA maneja la solicitud2.");
        }
    }

    class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateB manejar solicitud1.");
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateB manejar solicitud2");
            Console.WriteLine("ConcreteStateB quiere cambiar el estado del contexto.");
            this._context.TransitionTo(new ConcreteStateA());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}
