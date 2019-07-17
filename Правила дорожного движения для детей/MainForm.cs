/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 21.04.2019
 * Время: 23:53
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Правила_дорожного_движения_для_детей
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 fr1 = new Form1();
			fr1.Show();
			Hide();
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Разработчик: Салихов Ильяс Расихович","О программе"); 
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form7 fr7 = new Form7();
			fr7.Show();
			Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Form11 fr11 = new Form11();
			fr11.Show();
			Hide();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Form15 fr15 = new Form15();
			fr15.Show();
			Hide();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			Form19 fr19 = new Form19();
			fr19.Show();
			Hide();
		}
	}
}
