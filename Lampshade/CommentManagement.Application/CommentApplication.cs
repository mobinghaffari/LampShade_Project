using System.Collections.Generic;
using _0_Framework.Application;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Domain.CommentAgg;

namespace CommentManagement.Application
{
    public class CommentApplication:ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository; 
        }
        public OperationResult Add(AddComment command)
        {
            var operation = new OperationResult();
            var comment = new Comment(command.Name, command.Email, command.Message, command.OwnerRecordId,
                command.Type,command.Website,command.ParentId);
            _commentRepository.Create(comment);
            _commentRepository.SaveChanges();
            return operation.Succedded(); 
        }

        public OperationResult Confirm(long id)
        {
            var operation = new OperationResult();
            var comment = _commentRepository.Get(id);
            if (comment == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            comment.Canceled();

            _commentRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Cancel(long id)
        {
            var operation = new OperationResult();
            var comment = _commentRepository.Get(id);
            if (comment == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            comment.Confirmed(); 

            _commentRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            return _commentRepository.Search(searchModel);
        }
    }
}
