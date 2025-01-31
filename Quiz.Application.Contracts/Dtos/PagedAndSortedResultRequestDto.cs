﻿using System.ComponentModel.DataAnnotations;

namespace Quiz.Application.Dtos {
    public class PagedAndSortedResultRequestDto {

        [Range(1, int.MaxValue)]
        public virtual int MaxResultCount { get; set; } = 1000;

        [Range(0, int.MaxValue)]
        public virtual int SkipCount { get; set; } = 0;

        public virtual string? Sorting { get; set; }
    }
}
