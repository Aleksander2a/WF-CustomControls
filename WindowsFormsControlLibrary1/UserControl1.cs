using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class PasswordValidator_UserControl: UserControl
    {
        private bool PasswordIsOk { get; set; }
        private bool PasswordMatchesConfirmation { get; set; }
        public int MIN_CHARACTERS { get; set; }
        public int MIN_SPECIAL_CHARACTERS { get; set; }
        public int MIN_CAPITTAL_LETTERS { get; set; }
        public int MIN_DIGITS { get; set; }
        public bool NO_WHITESPACES { get; set; }
        public List<char> SPECIAL_CHARACTERS_LIST { get; set; }
        public string PASSWORD { get; set; }

        public PasswordValidator_UserControl()
        {
            /*
            MIN_CHARACTERS = minChars;
            MIN_SPECIAL_CHARACTERS = minSpecialChars;
            MIN_CAPITTAL_LETTERS = minCaptLett;
            MIN_DIGITS = minDigits;
            SPECIAL_CHARACTERS_LIST = specCharsList;
            */
            InitializeComponent();
        }

        private void PasswordValidator_UserControl_Load(object sender, EventArgs e)
        {
            Length_label.Visible = false;
            CharsCount_label.Visible = false;
            SpecialChars_label.Visible = false;
            SpecialCharsCount_label.Visible = false;
            CapitalLetters_label.Visible = false;
            CapitalLettersCount_label.Visible = false;
            Digits_label.Visible = false;
            DigitsCount_label.Visible = false;
            NoWhiteSpaces_label.Visible = false;
            NoWsValue_label.Visible = false;
            PassConfPasslabel.Visible = false;
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            PASSWORD = Password_textBox.Text;

            CharsCount_label.Text = MIN_CHARACTERS.ToString();
            SpecialCharsCount_label.Text = MIN_SPECIAL_CHARACTERS.ToString();
            CapitalLettersCount_label.Text = MIN_CAPITTAL_LETTERS.ToString();
            DigitsCount_label.Text = MIN_DIGITS.ToString();
            NoWsValue_label.Text = NO_WHITESPACES.ToString();

            Length_label.Visible = true;
            CharsCount_label.Visible = true;
            SpecialChars_label.Visible = true;
            SpecialCharsCount_label.Visible = true;
            CapitalLetters_label.Visible = true;
            CapitalLettersCount_label.Visible = true;
            Digits_label.Visible = true;
            DigitsCount_label.Visible = true;
            //NoWhiteSpaces_label.Visible = true;
            //NoWsValue_label.Visible = true;
            PassConfPasslabel.Visible = true;

            string password = Password_textBox.Text;
            string passwordConfirmation = ConfirmPassword_textBox.Text;

            int charsCount = password.Length;
            int specialCharsCount;
            if (SPECIAL_CHARACTERS_LIST == null)
            {
                specialCharsCount = 0;
            }
            else
            {
                specialCharsCount = password.Count(x => SPECIAL_CHARACTERS_LIST.Contains(x));
            }
            int capitalLettersCount = password.Count(x => Char.IsUpper(x));
            int digitsCount = password.Count(x => Char.IsDigit(x));

            int countOfSuccess = 0;
            // Check password length
            if (charsCount < MIN_CHARACTERS)
            {
                Length_label.ForeColor = Color.Red;
                CharsCount_label.ForeColor = Color.Red;
            }
            else
            {
                Length_label.ForeColor = Color.Green;
                CharsCount_label.ForeColor = Color.Green;
                countOfSuccess++;
            }
            // Check special characters
            if (specialCharsCount < MIN_SPECIAL_CHARACTERS)
            {
                SpecialChars_label.ForeColor = Color.Red;
                SpecialCharsCount_label.ForeColor = Color.Red;
            }
            else
            {
                SpecialChars_label.ForeColor = Color.Green;
                SpecialCharsCount_label.ForeColor = Color.Green;
                countOfSuccess++;
            }
            // Check capital letters
            if (capitalLettersCount < MIN_CAPITTAL_LETTERS)
            {
                CapitalLetters_label.ForeColor = Color.Red;
                CapitalLettersCount_label.ForeColor = Color.Red;
            }
            else
            {
                CapitalLetters_label.ForeColor = Color.Green;
                CapitalLettersCount_label.ForeColor = Color.Green;
                countOfSuccess++;
            }
            // Check digits
            if (digitsCount < MIN_DIGITS)
            {
                Digits_label.ForeColor = Color.Red;
                DigitsCount_label.ForeColor = Color.Red;
            }
            else
            {
                Digits_label.ForeColor = Color.Green;
                DigitsCount_label.ForeColor = Color.Green;
                countOfSuccess++;
            }
            // Check whitespaces
            int nrOfWhitespaces = password.Count(x => Char.IsWhiteSpace(x));
            if(NO_WHITESPACES)
            {
                NoWhiteSpaces_label.Visible = true;
                if (nrOfWhitespaces > 0)
                {
                    NoWhiteSpaces_label.ForeColor = Color.Red;
                    //NoWsValue_label.ForeColor = Color.Red;
                }
                else
                {
                    NoWhiteSpaces_label.ForeColor = Color.Green;
                    //NoWsValue_label.ForeColor = Color.Green;
                    countOfSuccess++;
                }
            }
            else
            {
                NoWhiteSpaces_label.ForeColor = Color.Green;
                //NoWsValue_label.ForeColor = Color.Green;
                countOfSuccess++;
            }

            // check if all is ok
            if (countOfSuccess == 5)
            {
                PasswordIsOk = true;
                if (password == passwordConfirmation)
                {
                    PasswordMatchesConfirmation = true;
                    PassConfPasslabel.ForeColor = Color.Green;
                    // inform app
                    StateChangedToValid(e);
                }
                else
                {
                    PasswordMatchesConfirmation = false;
                    PassConfPasslabel.ForeColor = Color.Red;
                    // inform app
                    StateChangedToInValid(e);
                }
            }
            else
            {
                PasswordIsOk = false;
                if (password == passwordConfirmation)
                {
                    PasswordMatchesConfirmation = true;
                    PassConfPasslabel.ForeColor = Color.Green;
                    // inform app
                    StateChangedToInValid(e);
                }
                else
                {
                    PasswordMatchesConfirmation = false;
                    PassConfPasslabel.ForeColor = Color.Red;
                    // inform app
                    StateChangedToInValid(e);
                }
            }
        }


        private void ConfirmPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            CharsCount_label.Text = MIN_CHARACTERS.ToString();
            SpecialCharsCount_label.Text = MIN_SPECIAL_CHARACTERS.ToString();
            CapitalLettersCount_label.Text = MIN_CAPITTAL_LETTERS.ToString();
            DigitsCount_label.Text = MIN_DIGITS.ToString();
            NoWsValue_label.Text = NO_WHITESPACES.ToString();

            Length_label.Visible = true;
            CharsCount_label.Visible = true;
            SpecialChars_label.Visible = true;
            SpecialCharsCount_label.Visible = true;
            CapitalLetters_label.Visible = true;
            CapitalLettersCount_label.Visible = true;
            Digits_label.Visible = true;
            DigitsCount_label.Visible = true;
            //NoWhiteSpaces_label.Visible = true;
            //NoWsValue_label.Visible = true;
            PassConfPasslabel.Visible = true;
            if (NO_WHITESPACES)
            {
                NoWhiteSpaces_label.Visible = true;
            }

            string password = Password_textBox.Text;
            string passwordConfirmation = ConfirmPassword_textBox.Text;

            if (password != passwordConfirmation)
            {
                PasswordMatchesConfirmation = false;
                PassConfPasslabel.ForeColor = Color.Red;
                // inform app
                StateChangedToInValid(e);
            }
            else
            {
                PasswordMatchesConfirmation = true;
                PassConfPasslabel.ForeColor = Color.Green;
                if (PasswordIsOk)
                {
                    // inform app
                    StateChangedToValid(e);
                }
                else
                {
                    // inform app
                    StateChangedToInValid(e);
                }
            }
        }

        //To create the event
        public event EventHandler StateToValid;

        protected virtual void StateChangedToValid(EventArgs e)
        {
            EventHandler handler = StateToValid;
            handler?.Invoke(this, e);
        }


        public event EventHandler StateToInValid;

        protected virtual void StateChangedToInValid(EventArgs e)
        {
            EventHandler handler = StateToInValid;
            handler?.Invoke(this, e);
        }
    }
}
