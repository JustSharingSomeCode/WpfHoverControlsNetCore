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
    /// Realice los pasos 1a o 1b y luego 2 para usar este control personalizado en un archivo XAML.
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
    ///     <MyNamespace:HoverScrollViewer/>
    ///
    /// </summary>
    public class HoverScrollViewer : ScrollViewer
    {
        static HoverScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HoverScrollViewer), new FrameworkPropertyMetadata(typeof(HoverScrollViewer)));
        }

        #region Brushes

        #region ScrollBarBackground

        [Category("Hover ScrollViewer")]

        public Brush ScrollBarBackground
        {
            get { return (Brush)GetValue(ScrollBarBackgroundProperty); }
            set { SetValue(ScrollBarBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ScrollBarBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScrollBarBackgroundProperty =
            DependencyProperty.Register("ScrollBarBackground", typeof(Brush), typeof(HoverScrollViewer), new PropertyMetadata(new SolidColorBrush(Colors.DarkGray)));

        #endregion

        #region ThumbBrush

        [Category("Hover ScrollViewer")]

        public Brush ThumbBrush
        {
            get { return (Brush)GetValue(ThumbBrushProperty); }
            set { SetValue(ThumbBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ThumbBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThumbBrushProperty =
            DependencyProperty.Register("ThumbBrush", typeof(Brush), typeof(HoverScrollViewer), new PropertyMetadata(new SolidColorBrush(Colors.Gray)));

        #endregion

        #endregion

        #region Border

        #region CornerRadius

        [Category("Hover ScrollViewer")]

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HoverScrollViewer), new PropertyMetadata(new CornerRadius(0)));

        #endregion

        #endregion

        #region ContentMargin

        [Category("Hover ScrollViewer")]

        public Thickness ContentMargin
        {
            get { return (Thickness)GetValue(ContentMarginProperty); }
            set { SetValue(ContentMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ContentMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentMarginProperty =
            DependencyProperty.Register("ContentMargin", typeof(Thickness), typeof(HoverScrollViewer), new PropertyMetadata(new Thickness(5)));

        #endregion
    }
}
