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
    ///     <MyNamespace:HoverTextBox/>
    ///
    /// </summary>
    public class HoverTextBox : TextBox
    {
        static HoverTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HoverTextBox), new FrameworkPropertyMetadata(typeof(HoverTextBox)));
        }

        #region Brushes

        #region Background

        [Category("Hover TextBox")]
        public new Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(HoverTextBox), new PropertyMetadata(Brushes.Black));

        #endregion

        #region BorderBrush

        [Category("Hover TextBox")]
        public new Brush BorderBrush
        {
            get { return (Brush)GetValue(BorderBrushProperty); }
            set { SetValue(BorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderBrush.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(HoverTextBox), new PropertyMetadata(Brushes.Gray));

        #endregion

        #endregion

        #region Hover

        #region BackgroundHover

        [Category("Hover TextBox")]

        public Brush BackgroundHover
        {
            get { return (Brush)GetValue(BackgroundHoverProperty); }
            set { SetValue(BackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), typeof(HoverTextBox), new PropertyMetadata(Brushes.White));

        #endregion

        #region BorderBrushHover

        [Category("Hover TextBox")]

        public Brush BorderBrushHover
        {
            get { return (Brush)GetValue(BorderBrushHoverProperty); }
            set { SetValue(BorderBrushHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderBrushHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BorderBrushHoverProperty =
            DependencyProperty.Register("BorderBrushHover", typeof(Brush), typeof(HoverTextBox), new PropertyMetadata(Brushes.Black));

        #endregion

        #endregion

        #region Border

        #region CornerRadius

        [Category("Hover TextBox")]
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HoverTextBox), new PropertyMetadata(new CornerRadius(5)));

        #endregion

        #region BorderThickness

        [Category("Hover TextBox")]
        public new Thickness BorderThickness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderThickness.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(HoverTextBox), new PropertyMetadata(new Thickness(1)));

        #endregion

        #endregion        
    }
}
