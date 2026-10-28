using Ninject.Modules;
using Model;
using DataAccess;


namespace BusinessLogic
{
    public class SimpleConfigModule : NinjectModule
    {
        private readonly int choice;
        public SimpleConfigModule(int choice)
        {
            this.choice = choice;
        }
        public override void Load()
        {
            if (choice == 1)
            {
                Bind<IRepository<Student>>()
                    .To<EntityRepository<Student>>();
            }
            else if (choice == 2)
            {
                Bind<IRepository<Student>>()
                    .To<DapperRepository<Student>>();
            }
            else
            {
                throw new ArgumentException(
                    "Неверный ввод");
            }
        }
    }
}
