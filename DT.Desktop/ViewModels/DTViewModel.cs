using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DT.Data;
using DT.Model;

namespace DT.Desktop.ViewModels
{
    public class DTViewModel
    {
        public DTViewModel(IDTUoW uow)
        {

            Topics = uow.TopicRepository.GetAll().ToList();
        }

        public IEnumerable<Topic> Topics { get; private set; } 
    }
}
