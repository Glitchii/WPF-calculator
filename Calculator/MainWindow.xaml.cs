using System;
using System.Collections.Generic;
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

namespace Calculator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window {
        Action<int> sleep = (int seconds) => { System.Threading.Thread.Sleep(seconds*1000); };
        public MainWindow() {
            InitializeComponent();
        }

        private void closeBTN_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) { Environment.Exit(0); }
        private void topDrag(object sender, MouseButtonEventArgs e) { DragMove(); }
        private void winLoaded(object sender, RoutedEventArgs e) {
            
        }

        private void closeBTN_MouseEnter(object sender, MouseEventArgs e) { closeBTN.Opacity=.6; closeBTN.Background=(Brush)new BrushConverter().ConvertFrom("#FF343436"); }
        private void closeBTN_MouseLeave(object sender, MouseEventArgs e) { closeBTN.Opacity=.3; closeBTN.Background=(Brush)new BrushConverter().ConvertFrom("#FF242426"); }

        string defaultOutputBoxText = "Standard calculator";
        long num1 = 0;
        long num2 = 0;
        string operation = "";
        List<string> btnDefault = new List<string> { "#FF313334" };
        List<string> btnHover = new List<string> { "#FF3A3B3C" };
        List<string> operatorsDefault = new List<string> { "#FF2B2D2E" };
        List<string> operatorsHover = new List<string> { "#FF363A3E" };
        List<string> equalsDefault = new List<string> { "#FF262829" };
        List<string> equalsHover = new List<string> { "#FF2F3030" };
        private void btn_MouseEnter(object sender, MouseEventArgs e) { btn.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn_MouseLeave(object sender, MouseEventArgs e) { btn.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn1_MouseEnter(object sender, MouseEventArgs e) { btn1.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn1_MouseLeave(object sender, MouseEventArgs e) { btn1.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn2_MouseEnter(object sender, MouseEventArgs e) { btn2.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn2_MouseLeave(object sender, MouseEventArgs e) { btn2.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn3_MouseEnter(object sender, MouseEventArgs e) { btn3.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn3_MouseLeave(object sender, MouseEventArgs e) { btn3.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn4_MouseEnter(object sender, MouseEventArgs e) { btn4.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn4_MouseLeave(object sender, MouseEventArgs e) { btn4.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn5_MouseEnter(object sender, MouseEventArgs e) { btn5.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn5_MouseLeave(object sender, MouseEventArgs e) { btn5.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn6_MouseEnter(object sender, MouseEventArgs e) { btn6.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn6_MouseLeave(object sender, MouseEventArgs e) { btn6.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn7_MouseEnter(object sender, MouseEventArgs e) { btn7.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn7_MouseLeave(object sender, MouseEventArgs e) { btn7.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn8_MouseEnter(object sender, MouseEventArgs e) { btn8.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn8_MouseLeave(object sender, MouseEventArgs e) { btn8.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btn9_MouseEnter(object sender, MouseEventArgs e) { btn9.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btn9_MouseLeave(object sender, MouseEventArgs e) { btn9.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btnPoint_MouseEnter(object sender, MouseEventArgs e) { btnPoint.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btnPoint_MouseLeave(object sender, MouseEventArgs e) { btnPoint.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void btnPower2_MouseEnter(object sender, MouseEventArgs e) { btnPower2.Background=(Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void btnPower2_MouseLeave(object sender, MouseEventArgs e) { btnPower2.Background=(Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }

        private void btnDivide_MouseEnter(object sender, MouseEventArgs e) { btnDivide.Background=(Brush)new BrushConverter().ConvertFrom(operatorsHover[0]); }
        private void btnDivide_MouseLeave(object sender, MouseEventArgs e) { btnDivide.Background=(Brush)new BrushConverter().ConvertFrom(operatorsDefault[0]); }
        private void btnTimes_MouseEnter(object sender, MouseEventArgs e) { btnTimes.Background=(Brush)new BrushConverter().ConvertFrom(operatorsHover[0]); }
        private void btnTimes_MouseLeave(object sender, MouseEventArgs e) { btnTimes.Background=(Brush)new BrushConverter().ConvertFrom(operatorsDefault[0]); }
        private void btnPlus_MouseEnter(object sender, MouseEventArgs e) { btnPlus.Background=(Brush)new BrushConverter().ConvertFrom(operatorsHover[0]); }
        private void btnPlus_MouseLeave(object sender, MouseEventArgs e) { btnPlus.Background=(Brush)new BrushConverter().ConvertFrom(operatorsDefault[0]); }
        private void btnMinus_MouseEnter(object sender, MouseEventArgs e) { btnMinus.Background=(Brush)new BrushConverter().ConvertFrom(operatorsHover[0]); }
        private void btnMinus_MouseLeave(object sender, MouseEventArgs e) { btnMinus.Background=(Brush)new BrushConverter().ConvertFrom(operatorsDefault[0]); }
        private void btnCE_MouseEnter(object sender, MouseEventArgs e) { btnCE.Background=(Brush)new BrushConverter().ConvertFrom(operatorsHover[0]); }
        private void btnCE_MouseLeave(object sender, MouseEventArgs e) { btnCE.Background=(Brush)new BrushConverter().ConvertFrom(operatorsDefault[0]); }
        private void btnC_MouseEnter(object sender, MouseEventArgs e) { btnC.Background=(Brush)new BrushConverter().ConvertFrom(operatorsHover[0]); }
        private void btnC_MouseLeave(object sender, MouseEventArgs e) { btnC.Background=(Brush)new BrushConverter().ConvertFrom(operatorsDefault[0]); }
        private void backSpace_MouseEnter(object sender, MouseEventArgs e) { backSpace.Background=(Brush)new BrushConverter().ConvertFrom(operatorsHover[0]); }
        private void backSpace_MouseLeave(object sender, MouseEventArgs e) { backSpace.Background=(Brush)new BrushConverter().ConvertFrom(operatorsDefault[0]); }
        private void btnEquals_MouseEnter(object sender, MouseEventArgs e) { btnEquals.Background=(Brush)new BrushConverter().ConvertFrom(equalsHover[0]); }
        private void btnEquals_MouseLeave(object sender, MouseEventArgs e) { btnEquals.Background=(Brush)new BrushConverter().ConvertFrom(equalsDefault[0]); }

        private void btn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10); display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10); display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+1; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+1; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+2; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+2; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+3; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+3; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+4; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+4; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+5; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+5; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+6; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+6; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+7; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+7; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+8; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+8; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btn9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=(num1*10)+9; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else {
                num2=(num2*10)+9; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btnPower2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation=="") {
                num1=num1*num1; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";; 
            } else {
                num2=num2*num2; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }
        private void btnPercent_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(num1==0&&num2==0) {
                display.Text="0"; outputs.Text="Click a number before using %. eg. 80% × 10010";
            } else if(operation=="") {
                num1=num1/100; display.Text=num1.ToString(); clarifier.Text=$"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2==0 ? "" : num2.ToString())}";;
            } else if(operation!="") {
                num2=num2/100; display.Text=num2.ToString(); clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+num2.ToString();
            }
        }

        private void btnDivide_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) { operation="/"; display.Text="0"; clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+(num2==0 ? "" : num2.ToString()); }
        private void btnTimes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) { operation="*"; display.Text="0"; clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+(num2==0 ? "" : num2.ToString()); }
        private void btnPlus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) { operation="+"; display.Text="0"; clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+(num2==0 ? "" : num2.ToString()); }
        private void btnMinus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) { operation="-"; display.Text="0"; clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+(num2==0 ? "" : num2.ToString()); }
        private void btnC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            operation=""; num1=0; num2=0; display.Text="0"; clarifier.Clear(); outputs.Text=defaultOutputBoxText;
        }
        private void btnCE_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(num2!=0) {
                num2=0; display.Text="0";
                clarifier.Text=$"{num1} {operation}";
            } else if(num2==0&&operation!="") {
                operation=""; display.Text="0";
                clarifier.Text=$"{num1}";
            } else if(num2==0&&operation=="") {
                num1=0; display.Text="0";
                clarifier.Text="";
            }
        }
        private void backSpace_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(num2!=0) {
                num2=(num2/10); display.Text=num2.ToString();
                clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" "+(num2==0 ? "" : num2.ToString());
            } else if(num2==0&&operation!="") {
                operation=""; display.Text="0";
                clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷")+" ";
            } else if(num2==0&&operation=="") {
                num1=(num1/10); display.Text=num1.ToString();
                clarifier.Text=num1.ToString();
            }
        }
        private void btnPoint_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void btnEquals_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            if(operation!=""&&num1!=0&&num2==0) {clarifier.Text=num1.ToString()+" "+operation.Replace("*", "×").Replace("/", "÷");} // This line isn't as import but it removes an unwanted space eg. Turns 2 +  = 2 to 2 + = 2. To test this, in the calculator press 2+=
            switch(operation) {
                case "/": display.Text=(num1/num2).ToString(); clarifier.Text+=" = "+(num1/num2).ToString(); break;
                case "*": display.Text=(num1*num2).ToString(); clarifier.Text+=" = "+(num1*num2).ToString(); break;
                case "+": display.Text=(num1+num2).ToString(); clarifier.Text+=" = "+(num1+num2).ToString(); break;
                case "-": display.Text=(num1-num2).ToString(); clarifier.Text+=" = "+(num1-num2).ToString(); break;
                case "": break;
                default: outputs.Text="There was an error. Press clear and try again."; break; // There is no way this line will be shown unless you changed something but I'll just leave it there.
            }
        }
    }
}
