using Sitecore.Data.Items;
using Sitecore.XA.Foundation.RenderingVariants.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.XA.Foundation.RenderingVariants.Pipelines.RenderVariantField
{
  public class RenderVariantField: Sitecore.XA.Foundation.RenderingVariants.Pipelines.RenderVariantField.RenderVariantField
  {
    #region patch
    protected override bool IsEmptyFieldToRender(VariantField variantField, Item item) =>
    (!variantField.RenderIfEmpty && string.IsNullOrWhiteSpace(item[variantField.FieldName]));
    #endregion
  }
}