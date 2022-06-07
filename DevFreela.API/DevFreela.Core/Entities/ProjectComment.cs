namespace DevFreela.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, string idProject, string idUser)
        {
            Content = content;
            IdProject = idProject;
            IdUser = idUser;
            CreatedAt = DateTime.Now;
        }

        public string Content { get; private set; }

        public string IdProject { get; private set; }

        public string IdUser { get; private set; }

        public DateTime CreatedAt { get; private set; }
    }
}