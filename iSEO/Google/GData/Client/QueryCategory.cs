namespace Google.GData.Client
{
	public class QueryCategory
	{
		private AtomCategory atomCategory_0;

		private QueryCategoryOperator queryCategoryOperator_0;

		private bool bool_0;

		public AtomCategory Category
		{
			get
			{
				return atomCategory_0;
			}
			set
			{
				atomCategory_0 = value;
			}
		}

		public QueryCategoryOperator Operator
		{
			get
			{
				return queryCategoryOperator_0;
			}
			set
			{
				queryCategoryOperator_0 = value;
			}
		}

		public bool Excluded
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public QueryCategory(AtomCategory category)
		{
			atomCategory_0 = category;
			queryCategoryOperator_0 = QueryCategoryOperator.AND;
		}

		public QueryCategory(string strCategory, QueryCategoryOperator op)
		{
			queryCategoryOperator_0 = op;
			strCategory = FeedQuery.smethod_1(strCategory);
			if (strCategory[0] == '-')
			{
				bool_0 = true;
				strCategory = strCategory.Substring(1, strCategory.Length - 1);
			}
			int num = strCategory.IndexOf('{');
			int num2 = strCategory.IndexOf('}');
			AtomUri scheme = null;
			if (num != -1 && num2 != -1)
			{
				num2++;
				num++;
				scheme = new AtomUri(strCategory.Substring(num, num2 - num - 1));
				strCategory = strCategory.Substring(num2, strCategory.Length - num2);
			}
			atomCategory_0 = new AtomCategory(strCategory, scheme);
		}
	}
}
