﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Promact.Trappist.DomainModel.Models.Question
{
    public class SingleMultipleAnswerQuestion : BaseModel
    {
        [ForeignKey("Id")]
        public virtual Question Question { get; set; }

        public virtual ICollection<SingleMultipleAnswerQuestionOption> SingleMultipleAnswerQuestionOption { get; set; }
    }
}
