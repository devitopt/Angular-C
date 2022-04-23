using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class OrderMarkdown
    {
        public int OrderMarkdownId { get; set; }
        public int? OrderMarkdownTypeId { get; set; }
        public decimal? Markdown { get; set; }
        public int? MarkdownCurrency { get; set; }
        public decimal? MarkdownExchangeRate { get; set; }
        public int? OrderId { get; set; }

        public virtual Currency MarkdownCurrencyNavigation { get; set; }
        public virtual Order Order { get; set; }
    }
}
