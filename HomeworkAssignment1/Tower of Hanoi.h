#pragma once

namespace HomeworkAssignment1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for TowerofHanoi
	/// </summary>
	public ref class TowerofHanoi : public System::Windows::Forms::Form
	{
	public:
		TowerofHanoi(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~TowerofHanoi()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::NumericUpDown^ numericUpDown1;
	protected:
	private: System::Windows::Forms::NumericUpDown^ numericUpDown2;
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::FlowLayoutPanel^ flowLayoutPanel1;
	private: System::Windows::Forms::FlowLayoutPanel^ flowLayoutPanel2;
	private: System::Windows::Forms::FlowLayoutPanel^ flowLayoutPanel3;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::Button^ button4;
	private: System::Windows::Forms::Button^ button5;
	private: System::Windows::Forms::Button^ button6;
	private: System::Windows::Forms::Button^ button7;
	private: System::Windows::Forms::Button^ button8;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->numericUpDown1 = (gcnew System::Windows::Forms::NumericUpDown());
			this->numericUpDown2 = (gcnew System::Windows::Forms::NumericUpDown());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->flowLayoutPanel1 = (gcnew System::Windows::Forms::FlowLayoutPanel());
			this->flowLayoutPanel2 = (gcnew System::Windows::Forms::FlowLayoutPanel());
			this->flowLayoutPanel3 = (gcnew System::Windows::Forms::FlowLayoutPanel());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->button6 = (gcnew System::Windows::Forms::Button());
			this->button7 = (gcnew System::Windows::Forms::Button());
			this->button8 = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown2))->BeginInit();
			this->SuspendLayout();
			// 
			// numericUpDown1
			// 
			this->numericUpDown1->Location = System::Drawing::Point(113, 46);
			this->numericUpDown1->Name = L"numericUpDown1";
			this->numericUpDown1->Size = System::Drawing::Size(60, 26);
			this->numericUpDown1->TabIndex = 0;
			this->numericUpDown1->ValueChanged += gcnew System::EventHandler(this, &TowerofHanoi::numericUpDown1_ValueChanged);
			// 
			// numericUpDown2
			// 
			this->numericUpDown2->Location = System::Drawing::Point(742, 47);
			this->numericUpDown2->Name = L"numericUpDown2";
			this->numericUpDown2->Size = System::Drawing::Size(62, 26);
			this->numericUpDown2->TabIndex = 1;
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(23, 44);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(85, 28);
			this->button1->TabIndex = 2;
			this->button1->Text = L"New";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &TowerofHanoi::button1_Click);
			// 
			// flowLayoutPanel1
			// 
			this->flowLayoutPanel1->Location = System::Drawing::Point(33, 79);
			this->flowLayoutPanel1->Name = L"flowLayoutPanel1";
			this->flowLayoutPanel1->Size = System::Drawing::Size(188, 386);
			this->flowLayoutPanel1->TabIndex = 3;
			// 
			// flowLayoutPanel2
			// 
			this->flowLayoutPanel2->Location = System::Drawing::Point(320, 79);
			this->flowLayoutPanel2->Name = L"flowLayoutPanel2";
			this->flowLayoutPanel2->Size = System::Drawing::Size(200, 386);
			this->flowLayoutPanel2->TabIndex = 4;
			// 
			// flowLayoutPanel3
			// 
			this->flowLayoutPanel3->Location = System::Drawing::Point(604, 79);
			this->flowLayoutPanel3->Name = L"flowLayoutPanel3";
			this->flowLayoutPanel3->Size = System::Drawing::Size(200, 386);
			this->flowLayoutPanel3->TabIndex = 5;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(316, 52);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(111, 20);
			this->label1->TabIndex = 6;
			this->label1->Text = L"Move Count: 0";
			this->label1->Click += gcnew System::EventHandler(this, &TowerofHanoi::label1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(602, 46);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(75, 31);
			this->button2->TabIndex = 0;
			this->button2->Text = L"Solve";
			this->button2->UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(683, 51);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(53, 20);
			this->label2->TabIndex = 7;
			this->label2->Text = L"Delay:";
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(23, 471);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(93, 46);
			this->button3->TabIndex = 8;
			this->button3->Text = L"Move Left";
			this->button3->UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(122, 471);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(99, 46);
			this->button4->TabIndex = 9;
			this->button4->Text = L"Move Right";
			this->button4->UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(320, 471);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(88, 46);
			this->button5->TabIndex = 10;
			this->button5->Text = L"Move Left";
			this->button5->UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this->button6->Location = System::Drawing::Point(414, 471);
			this->button6->Name = L"button6";
			this->button6->Size = System::Drawing::Size(106, 46);
			this->button6->TabIndex = 11;
			this->button6->Text = L"Move Right";
			this->button6->UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this->button7->Location = System::Drawing::Point(604, 471);
			this->button7->Name = L"button7";
			this->button7->Size = System::Drawing::Size(92, 46);
			this->button7->TabIndex = 12;
			this->button7->Text = L"Move Left";
			this->button7->UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this->button8->Location = System::Drawing::Point(702, 471);
			this->button8->Name = L"button8";
			this->button8->Size = System::Drawing::Size(102, 46);
			this->button8->TabIndex = 13;
			this->button8->Text = L"Move Right";
			this->button8->UseVisualStyleBackColor = true;
			// 
			// TowerofHanoi
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(9, 20);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(834, 639);
			this->Controls->Add(this->button8);
			this->Controls->Add(this->button7);
			this->Controls->Add(this->button6);
			this->Controls->Add(this->button5);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->flowLayoutPanel3);
			this->Controls->Add(this->flowLayoutPanel2);
			this->Controls->Add(this->flowLayoutPanel1);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->numericUpDown2);
			this->Controls->Add(this->numericUpDown1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->Name = L"TowerofHanoi";
			this->Text = L"TowerofHanoi";
			this->Load += gcnew System::EventHandler(this, &TowerofHanoi::TowerofHanoi_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numericUpDown2))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void TowerofHanoi_Load(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void numericUpDown1_ValueChanged(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
	}
private: System::Void label1_Click(System::Object^ sender, System::EventArgs^ e) {
}
};
}
