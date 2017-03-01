using System;
using System.Windows;

using DeXign.Core;
using DeXign.Core.Logic;
using DeXign.Editor.Layer;

namespace DeXign.Editor.Renderer
{
    public class StoryboardRenderer : StoryboardLayer, IRenderer, IStoryboard
    {
        public FrameworkElement Element => (FrameworkElement)AdornedElement;

        public PObject Model { get; set; }

        public StoryboardRenderer(UIElement adornedElement) : base(adornedElement)
        {
        }

        public void OnAddedChild(IRenderer child)
        {
        }

        public void OnRemovedChild(IRenderer child)
        {
        }

        #region [ IBinderProvider ]
        public bool CanBind(BaseBinder outputBinder, BinderOptions options)
        {
            throw new NotImplementedException();
        }

        public void Bind(BaseBinder outputBinder, BinderOptions options)
        {
            throw new NotImplementedException();
        }

        public void ReleaseInput(BaseBinder outputBinder)
        {
            throw new NotImplementedException();
        }

        public void ReleaseOutput(BaseBinder inputBinder)
        {
            throw new NotImplementedException();
        }

        public void ReleaseAll()
        {
            throw new NotImplementedException();
        }

        public BaseBinder ProvideValue()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
