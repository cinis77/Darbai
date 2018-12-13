using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCexample
{
    public interface IModelAdapter
    {
        void V(); // V - View
    }

    public interface IViewAdapter
    {
        object M(object input); // M - model
    }

    public interface IModel
    {
        void SetAdapter(IModelAdapter adapter);

        object M(object input); // M - model
    }

    public interface IView
    {
        void SetAdapter(IViewAdapter adapter);

        void V(); // V- View
    }

    public delegate IModel ModelFactory(); // Factory design pattern

    public delegate IView ViewFactory();  // Factory design pattern

    public class Model : IModel
    {
        private IModelAdapter _adapter;

        public object M(object input)
        {
            string zodis = (string)input;
            zodis = "8" + zodis + "8";
            return zodis;
        }

        public void SetAdapter(IModelAdapter adapter)
        {
            _adapter = adapter;
        }
    }

    public class ModelV2 : IModel
    {
        private IModelAdapter _adapter;

        public object M(object input)
        {
            string zodis = (string)input;
            zodis = "6" + zodis + "6";
            return zodis;
        }

        public void SetAdapter(IModelAdapter adapter)
        {
            _adapter = adapter;
        }
    }

    public class View : IView
    {
        private IViewAdapter _adapter;

        public void SetAdapter(IViewAdapter adapter)
        {
            _adapter = adapter;
        }

        public void V()
        {
            Console.WriteLine("Iveskite zodi");
            string duomenys = Console.ReadLine();
            Console.WriteLine(_adapter.M(duomenys));
        }
    }

    public class Controller : IViewAdapter, IModelAdapter
    {
        private IView _view;
        private IModel _model;

        public Controller(ModelFactory mf, ViewFactory vf)
        {
            _model = mf();
            _view = vf();
            _model.SetAdapter(this);
            _view.SetAdapter(this);
        }

        public object M(object input)
        {
            return _model.M(input);
        }

        public void V()
        {
            _view.V();
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Controller c = new Controller(MYModeV2Setter, MYViewSetter);
            c.V();
            Console.ReadKey();
        }

        public static IModel MyModelSetter()
        {
            return new Model();
        }

        public static IModel MYModeV2Setter()
        {
            return new ModelV2();
        }

        public static IView MYViewSetter()
        {
            return new View();
        }
    }
}