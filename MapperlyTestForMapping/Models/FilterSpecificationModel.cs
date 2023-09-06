using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping.Models
{
    public class FilterSpecificationModel
    {
        public FromAndToDate FromAndToDate { get; set; }
        public int[]? Stoftyper { get; set; }
        public int[]? Formatter { get; set; }
        public int? NewsValue { get; set; }
        public int? Limit { get; set; }

        public FilterSpecificationModel(DateOnly from, DateOnly to, int[]? stoftyper, int[]? formatter, int? newsValue, int? limit)
        {
            FromAndToDate = new FromAndToDate(from, to);
            Stoftyper = stoftyper;
            Formatter = formatter;
            NewsValue = newsValue;
            Limit = limit;
        }       
    }
    public record FromAndToDate(DateOnly From, DateOnly To);
}
