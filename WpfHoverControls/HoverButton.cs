using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHoverControls
{
    /// <summary>
    ///  Realice los pasos 1a o 1b y luego 2 para usar este control personalizado en un archivo XAML.
    ///
    /// Paso 1a) Usar este control personalizado en un archivo XAML existente en el proyecto actual.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfHoverControls"
    ///
    ///
    /// Paso 1b) Usar este control personalizado en un archivo XAML existente en otro proyecto.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfHoverControls;assembly=WpfHoverControls"
    ///
    /// Tendrá también que agregar una referencia de proyecto desde el proyecto en el que reside el archivo XAML
    /// hasta este proyecto y recompilar para evitar errores de compilación:
    ///
    ///     Haga clic con el botón secundario del mouse en el proyecto de destino en el Explorador de soluciones y seleccione
    ///     "Agregar referencia"->"Proyectos"->[Busque y seleccione este proyecto]
    ///
    ///
    /// Paso 2)
    /// Prosiga y utilice el control en el archivo XAML.
    ///
    ///     <MyNamespace:HoverButton/>
    ///
    /// </summary>
    public class HoverButton : Button
    {
        static HoverButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HoverButton), new FrameworkPropertyMetadata(typeof(HoverButton)));
        }

        #region Flags

        #region ShowIcon

        [Category("Hover Button")]
        public bool ShowIcon
        {
            get { return (bool)GetValue(ShowIconProperty); }
            set { SetValue(ShowIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowIconProperty =
            DependencyProperty.Register("ShowIcon", typeof(bool), typeof(HoverButton), new PropertyMetadata(true));

        #endregion

        #endregion

        #region Button Content

        #region Content

        [Category("Hover Button")]
        public new object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(HoverButton), new PropertyMetadata("Hover Button"));

        #endregion

        #region IconText

        [Category("Hover Button")]
        public string IconText
        {
            get { return (string)GetValue(IconTextProperty); }
            set { SetValue(IconTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconTextProperty =
            DependencyProperty.Register("IconText", typeof(string), typeof(HoverButton), new PropertyMetadata("\uE001"));

        #endregion

        #endregion

        #region Brushes

        #region Background

        [Category("Hover Button")]
        public new Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(HoverButton), new PropertyMetadata(Brushes.Black));

        #endregion

        #region BorderBrush

        [Category("Hover Button")]
        public new Brush BorderBrush
        {
            get { return (Brush)GetValue(BorderBrushProperty); }
            set { SetValue(BorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderBrush.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(HoverButton), new PropertyMetadata(Brushes.Gray));

        #endregion

        #region Foreground

        [Category("Hover Button")]
        public new Brush Foreground
        {
            get { return (Brush)GetValue(ForegroundProperty); }
            set { SetValue(ForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Foreground.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register("Foreground", typeof(Brush), typeof(HoverButton), new PropertyMetadata(Brushes.White));

        #endregion

        #region IconForeground

        [Category("Hover Button")]
        public Brush IconForeground
        {
            get { return (Brush)GetValue(IconForegroundProperty); }
            set { SetValue(IconForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconForegroundProperty =
            DependencyProperty.Register("IconForeground", typeof(Brush), typeof(HoverButton), new PropertyMetadata(new SolidColorBrush(Colors.White)));

        #endregion

        #endregion

        #region Hover

        #region BackgroundHover

        [Category("Hover Button")]
        public Brush BackgroundHover
        {
            get { return (Brush)GetValue(BackgroundHoverProperty); }
            set { SetValue(BackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), typeof(HoverButton), new PropertyMetadata(Brushes.DarkGray));

        #endregion

        #region ForegroundHover

        [Category("Hover Button")]
        public Brush ForegroundHover
        {
            get { return (Brush)GetValue(ForegroundHoverProperty); }
            set { SetValue(ForegroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ForegroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForegroundHoverProperty =
            DependencyProperty.Register("ForegroundHover", typeof(Brush), typeof(HoverButton), new PropertyMetadata(Brushes.Black));

        #endregion

        #region IconForegroundHover

        [Category("Hover Button")]
        public Brush IconForegroundHover
        {
            get { return (Brush)GetValue(IconForegroundHoverProperty); }
            set { SetValue(IconForegroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconForegroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconForegroundHoverProperty =
            DependencyProperty.Register("IconForegroundHover", typeof(Brush), typeof(HoverButton), new PropertyMetadata(Brushes.Black));
        
        #endregion

        #endregion        

        #region Fonts

        #region IconFont

        [Category("Hover Button")]
        public FontFamily IconFont
        {
            get { return (FontFamily)GetValue(IconFontProperty); }
            set { SetValue(IconFontProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFont.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFontProperty =
            DependencyProperty.Register("IconFont", typeof(FontFamily), typeof(HoverButton), new PropertyMetadata(new FontFamily("Segoe MDL2 Assets")));

        #endregion

        #region TextFont

        [Category("Hover Button")]
        public FontFamily TextFont
        {
            get { return (FontFamily)GetValue(TextFontProperty); }
            set { SetValue(TextFontProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ContentFont.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextFontProperty =
            DependencyProperty.Register("TextFont", typeof(FontFamily), typeof(HoverButton), new PropertyMetadata(new FontFamily("Segoe UI")));

        #endregion

        #region IconFontSize

        [Category("Hover Button")]
        public double IconFontSize
        {
            get { return (double)GetValue(IconFontSizeProperty); }
            set { SetValue(IconFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFontSizeProperty =
            DependencyProperty.Register("IconFontSize", typeof(double), typeof(HoverButton), new PropertyMetadata((double)12));

        #endregion

        #region TextFontSize

        [Category("Hover Button")]
        public double TextFontSize
        {
            get { return (double)GetValue(TextFontSizeProperty); }
            set { SetValue(TextFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextFontSizeProperty =
            DependencyProperty.Register("TextFontSize", typeof(double), typeof(HoverButton), new PropertyMetadata((double)12));

        #endregion

        #endregion

        #region Border

        [Category("Hover Button")]
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HoverButton), new PropertyMetadata(new CornerRadius(5)));


        [Category("Hover Button")]
        public new Thickness BorderThickness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderThickness.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(HoverButton), new PropertyMetadata(new Thickness(1)));



        #endregion

        #region Content Alignment

        [Category("Hover Button")]
        public new HorizontalAlignment HorizontalContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(HorizontalContentAlignmentProperty); }
            set { SetValue(HorizontalContentAlignmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HorizontalContentAlignment.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty HorizontalContentAlignmentProperty =
            DependencyProperty.Register("HorizontalContentAlignment", typeof(HorizontalAlignment), typeof(HoverButton), new PropertyMetadata(HorizontalAlignment.Center));

        [Category("Hover Button")]
        public new VerticalAlignment VerticalContentAlignment
        {
            get { return (VerticalAlignment)GetValue(VerticalContentAlignmentProperty); }
            set { SetValue(VerticalContentAlignmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VerticalContentAlignment.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty VerticalContentAlignmentProperty =
            DependencyProperty.Register("VerticalContentAlignment", typeof(VerticalAlignment), typeof(HoverButton), new PropertyMetadata(VerticalAlignment.Center));


        #endregion

    }
}
