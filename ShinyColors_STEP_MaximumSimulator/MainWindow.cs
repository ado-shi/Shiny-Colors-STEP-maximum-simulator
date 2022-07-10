using System;
using System.Windows.Forms;

namespace ShinyColors_STEP_MaximumSimulator
{
    public partial class MainWindow : Form
    {
        private int status;
        private int statusLimit;
        private int skillLevel;
        private int skillPoint;
        private int statusCount;
        private int statusLimitCount;

		//-------------------------------
		//  Instance 
		//-------------------------------

		public MainWindow()
        {
            InitializeComponent();
			
        }


		//-------------------------------
		//  EventHandler 
		//-------------------------------

		/// <summary>
		/// じっこうボタン押下
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonExecuteClick(object sender, EventArgs e)
        {
            try {
                status = int.Parse(textStatus.Text);
                statusLimit = int.Parse(textStatusLimit.Text);
                skillLevel = int.Parse(textSkillLevel.Text);
                skillPoint = int.Parse(textSkillPoint.Text);
                statusCount = int.Parse(textStatusCount.Text);
                statusLimitCount = int.Parse(textStatusLimitCount.Text);
            }
            catch (Exception) {
                // 無いと思うけど。。。
                textResult.Text = "入力パラメータが不正です。";

            }
            textResult.Text = "計算中";

			// ステータス計算実行
			ExecuteCalc();
        }

		/// <summary>
		/// ステータス入力項目制限
		///  TextBoxへの数値以外の入力を制限
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void TextStatusKeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }


		//-------------------------------
		//  Internals
		//-------------------------------
		
		/// <summary>
		/// ステータス計算
		/// </summary>
		private void ExecuteCalc() 
        {
			int requiredStatusPoint = 0;              //ステータスの次の成長に必要な熟練度(歌唱力or安定感or表現力or集中力)
			int requiredLimitPoint = 0;               //ステータス上限の次の成長に必要な熟練度(歌唱力or安定感or表現力or集中力)
			int requiredStatusSkillPoint = 0;         //ステータスの次の成長に必要な団結力
			int requiredLimitSkillPoint = 0;        　//ステータス上限の次の成長に必要な団結力
			int initialSkillPoint = skillPoint;       //団結力の初期値

            /* ToDo:値の入力制限を実装 */

            //ステータスが成長できるorステータス上限値が成長できる場合実行
            while ((skillLevel - requiredStatusPoint >= 0 && skillPoint - requiredStatusSkillPoint >= 0)                        
				|| (skillLevel - requiredLimitPoint >= 0 && skillPoint - requiredLimitSkillPoint >= 0) && (statusCount < 230))　//
			{
                //ステータスとステータス上限値の次の成長に必要な必要熟練度pt及び必要団結力を求める
                RequiredPoint(statusCount, requiredStatusPoint, requiredStatusSkillPoint, ref statusCount, ref requiredStatusPoint, ref requiredStatusSkillPoint);
                RequiredPoint(statusLimitCount, requiredLimitPoint, requiredLimitSkillPoint, ref statusLimitCount, ref requiredLimitPoint, ref requiredLimitSkillPoint);

                if (((status + 10) <= statusLimit)                    //特化ステータスが上限値-10の値で成長できる
                    && ((skillLevel - requiredStatusPoint) >= 0)      //かつ、特化ステータスの成長に必要な熟練度ptを保持している
                    && ((skillPoint - requiredStatusSkillPoint) >= 0) //かつ、特化ステータスの成長に必要な団結力ptを保持している
                    && (statusCount < 230))                           //かつ、特化ステータスの成長回数が230回(カンスト)未満の場合、実行
                {                                       
                    status = status + 10;
                    skillLevel = skillLevel - requiredStatusPoint;
                    skillPoint = skillPoint - requiredStatusSkillPoint;
                    statusCount++;
                }
                else if (((skillLevel - requiredLimitPoint) >= 0)     //上のif文が実行されず、特化ステータス上限値の成長に必要な熟練度ptを保持している
                    && ((statusLimit - status) <= 10)                 //かつ、現在の特化ステータスと上限値の差が10以下
                    && ((skillLevel - 2 * requiredStatusPoint) >= 0)  //かつ、熟練度が2回の成長で枯渇しない
                    && ((skillPoint - requiredLimitSkillPoint) >= 0)  //かつ、特化ステータス上限値の成長に必要な団結力ptを保持している
                    && (statusLimitCount < 140))                      //かつ、特化ステータス上限の成長回数が140回(カンスト)未満の場合、実行
                {
                    statusLimit = statusLimit + 10;
                    skillLevel = skillLevel - requiredLimitPoint;
                    skillPoint = skillPoint - requiredLimitSkillPoint;
                    statusLimitCount++;

                }
                else if ((status < statusLimit)                       //上記のif文、else if文が実行されず、現在の特化ステータス値が上限値以下
                    && ((skillLevel - requiredStatusPoint) >= 0)      //特化ステータスの成長に必要な熟練度ptを保持している
                    && ((skillPoint - requiredStatusSkillPoint) >= 0) //かつ、特化ステータスの成長に必要な団結力ptを保持している
                    && (statusCount < 230))                           //かつ、特化ステータスの成長回数が230回(カンスト)未満の場合、実行
                {                                       
                    status = statusLimit;
                    skillLevel = skillLevel - requiredStatusPoint;
                    skillPoint = skillPoint - requiredStatusSkillPoint;
                    statusCount++;
                }
                else
                {
                    // 計算終了
                    break;
                }

            }

            // 計算結果表示
            textResult.Text = "最終的な最大ステータス情報は\r\n";
            textResult.AppendText(String.Format("特化ステータス:{0}\r\n", status));
            textResult.AppendText(String.Format("特化上限:{0}\r\n", statusLimit));
            textResult.AppendText(String.Format("累計特化ステータス成長回数:{0}\r\n", statusCount));
            textResult.AppendText(String.Format("累計特化上限成長回数:{0}\r\n", statusLimitCount));
            textResult.AppendText(String.Format("残り熟練度:{0}\r\n", skillLevel));
            textResult.AppendText(String.Format("残り団結力:{0}\r\n\r\n", skillPoint));

            textResult.AppendText(String.Format("SP変換可能回数:{0}\r\n", skillPoint / 30));
            textResult.AppendText(String.Format("SP変換値:{0}\r\n", skillPoint / 30 * 10));
            textResult.AppendText(String.Format("SP変換後残り団結力:{0}\r\n", initialSkillPoint - 30 * (skillPoint / 30)));
            textResult.AppendText(String.Format("上記を目安にSPに変換、上限パネルを解放した後もう一度実行してください\r\n"));

        }

        /// <summary>
        /// 特化ステータスor上限の次の成長に必要な熟練度と団結力の値を返す関数
        /// </summary>
        /// <param name="count"></param>
        /// <param name="point"></param>
        /// <param name="danketsuryoku_point"></param>
        /// <param name="p_count"></param>
        /// <param name="p_point"></param>
        /// <param name="p_danketsuryoku_point"></param>
        /// <returns></returns>
        private static int RequiredPoint(int count, int point, int danketsuryoku_point, ref int p_count, ref int p_point, ref int p_danketsuryoku_point)
		{
			if (0 <= count && count < 30)
			{
				point = 10;
				danketsuryoku_point = 0;
			}
			else if (30 <= count && count < 60)
			{
				point = 15;
				danketsuryoku_point = 0;
			}
			else if (60 <= count && count < 90)
			{
				point = 20;
				danketsuryoku_point = 1;
			}
			else if (90 <= count && count < 120)
			{
				point = 30;
				danketsuryoku_point = 2;
			}
			else if (120 <= count && count < 150)
			{
				point = 40;
				danketsuryoku_point = 3;
			}
			else if (150 <= count && count < 230)
			{
				point = 50;
				danketsuryoku_point = 4;
			}
			p_count = count;
			p_point = point;
			p_danketsuryoku_point = danketsuryoku_point;
			return 0;
		}

    }

}
