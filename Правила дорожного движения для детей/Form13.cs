﻿/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 27.04.2019
 * Время: 17:21
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Правила_дорожного_движения_для_детей
{
	/// <summary>
	/// Description of Form13.
	/// </summary>
	public partial class Form13 : Form
	{
		public Form13()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MainForm fr2 = new MainForm();
			fr2.Show();
			Hide();
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			Form14 fr14 = new Form14();
			fr14.Show();
			Hide();
		}
	}
}
