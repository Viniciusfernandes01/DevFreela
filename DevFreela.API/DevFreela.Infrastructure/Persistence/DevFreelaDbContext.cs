using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("meu projeto", "minha descricao", 1, 1, 1)
            };

            Users = new List<User>
            {
                new User("vinicius", "vinicius@gmail", DateTime.Now)
            };

            Skills = new List<Skill>
            {
                new Skill("c#")
            };
        }


        public List<Project> Projects { get; set; }

        public List<User> Users { get; set; }

        public List<Skill> Skills { get; set; }

        public List<ProjectComment> ProjectComments { get; set; }

    }
}
