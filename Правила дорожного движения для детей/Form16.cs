﻿/*
 * Сделано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 29.04.2019
 * Время: 1:45
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Правила_дорожного_движения_для_детей
{
	/// <summary>
	/// Description of Form16.
	/// </summary>
	public partial class Form16 : Form
	{
		public Form16()
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
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			MessageBox.Show("НЕПРАВИЛЬНО!!!", "Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			Form17 fr17 = new Form17();
			fr17.Show();
			Hide();
		}
	}
}
