using PresseMots.Models;
using System.Collections.Generic;

namespace PresseMots.ViewModels
{
    public class CommentsVM
    {
        public int WordCount { get; set; }

        public string StoryTitle { get; set; }

        public string ShortStory { get; set; }

        public int StoryId { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
