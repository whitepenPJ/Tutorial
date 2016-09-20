using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace InCoze.Standard.Utilities
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString ICCheckBoxFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, object htmlLabelAttributes = null, object htmlCheckBoxAttributes = null)
        {
            var checkbox = htmlHelper.CheckBoxFor(expression, htmlCheckBoxAttributes);

            var labelTag = new TagBuilder("label");
            var divTag = new TagBuilder("div");
            var checkboxName = ExpressionHelper.GetExpressionText(expression);
            divTag.AddCssClass("checkbox");
            labelTag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlLabelAttributes));
            labelTag.InnerHtml = checkbox.ToString() + " " + LabelHelper(ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData), checkboxName);
            divTag.InnerHtml = labelTag.ToString();

            return new MvcHtmlString(divTag.ToString());
        }

        private static MvcHtmlString LabelHelper(ModelMetadata metadata, string fieldName)
        {
            string labelText;
            var displayName = metadata.DisplayName;

            if (displayName == null)
            {
                var propertyName = metadata.PropertyName;

                labelText = propertyName ?? fieldName.Split(new[] { '.' }).Last();
            }
            else
            {
                labelText = displayName;
            }

            if (string.IsNullOrEmpty(labelText))
            {
                return MvcHtmlString.Empty;
            }

            return new MvcHtmlString(labelText);
        }
    }
}
