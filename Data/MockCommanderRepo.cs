using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                 new Command{Id = 0, HowTo = "Boil an egg", Line= "Boil water", Platform = "Kettle & Pan"},
                 new Command{Id = 1, HowTo = "Cut bread", Line= "Boil water", Platform = "Kettle & Pan"},
                 new Command{Id = 2, HowTo = "Boil an egg", Line= "Boil water", Platform = "Kettle & Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id = 0, HowTo = "Boil an egg", Line= "Boil water", Platform = "Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmpd)
        {
            throw new NotImplementedException();
        }
    }
}