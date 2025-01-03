using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class EditCommentCommand : BaseCommand
    {
        public Guid Commentid { get; set; }
        public string Comment { get; set;} = "";

        public string Username { get; set;} = "";
    }
}