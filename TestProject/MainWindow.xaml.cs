using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace TestProject
{
  
    // 메인 윈도우

    public partial class MainWindow : Window
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// 타이머
        
        private DispatcherTimer timer;

        /// <summary>
        /// 깜박임 여부
        /// </summary>
        private bool isBlinking = false;

        #endregion

        
        #region 생성자 - MainWindow()
        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region 윈도우 로드시 처리하기 - Window_Loaded(sender, e)

        /// <summary>
        /// 윈도우 로드시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.timer = new DispatcherTimer();
            this.timer.Interval = new TimeSpan(0, 0, 0, 0, 500); //년/월/일/시/분/
            this.timer.Tick += timer_Tick;
            this.timer.Start();
        }

        #endregion
        #region 타이머 틱 처리하기 - timer_Tick(sender, e)

  
        /// 타이머 틱 처리하기

        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if(this.isBlinking) //isBlinking 깜빡이 여부
            {

                this.border1.Background = Brushes.White;
                this.border2.Background = Brushes.Green;

            }
            else
            {
                this.border1.Background = Brushes.Green;
                this.border2.Background = Brushes.White;
            }

            this.isBlinking = !this.isBlinking;
        }

        #endregion
    }
}