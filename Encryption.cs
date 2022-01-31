using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Encryption
    {
        List<char> symbols = new List<char>();
        List<char> alphabets = new List<char>();
        public Encryption(){

            symbols.Add('!');
            symbols.Add('@');
            symbols.Add('#');
            symbols.Add('$');
            symbols.Add('^');
            symbols.Add('&');
            symbols.Add('*');
            symbols.Add('(');
            symbols.Add(')');
            symbols.Add('_');
            symbols.Add('-');
            symbols.Add('+');
            symbols.Add('=');
            symbols.Add('?');
            symbols.Add(',');
            symbols.Add('{');
            symbols.Add('}');
            symbols.Add('[');
            symbols.Add(']');
            symbols.Add('/');
            symbols.Add('|');
            symbols.Add(';');
            symbols.Add(':');
            symbols.Add('.');
            symbols.Add('<');
            symbols.Add('>');

            for(char letter='a';letter<='z';letter++){
                alphabets.Add(letter);
            }
        }
        public char return_alphabet(int x){
            return alphabets[x];
        }

        public int return_alphabet_index(char x){
            return alphabets.IndexOf(char.Parse(x.ToString().ToLower()));
        }

        public char return_symbol(int x){
            return symbols[x];
        }

        public int return_symbol_index(char x){
            return symbols.IndexOf(x);
        }

        public string encrypt_message(string message){
            string lowerCaseMessage = message.ToLower();
            char[] charArr = lowerCaseMessage.ToCharArray();

            List<int> numList = new List<int>();
            List<char> newMessage = new List<char>();

            for(int i=0;i<charArr.Length;i++){
                if(alphabets.Contains(charArr[i]) == false){
                    return "Error: Invalid Character";
                }
                numList.Add(return_alphabet_index(charArr[i]));
            }

            for(int i=0; i<numList.Count;i++){
                newMessage.Add(return_symbol(numList[i]));
            }
            
            string encryptedMessage = string.Join("",newMessage);
         return encryptedMessage;
        
        }

        public string decrypt_message(string message){
            List<int> numList = new List<int>();
            List<char> newMessage = new List<char>();
            char[] charArr = message.ToCharArray();

            for(int i =0; i<charArr.Length; i++){
                if(symbols.Contains(charArr[i]) == false){
                    return "Error: Invalid Symbol";
                }
                numList.Add(return_symbol_index(charArr[i]));
            }
            
            for(int i = 0; i<numList.Count; i++){
                newMessage.Add(return_alphabet(numList[i]));
            }
            string finalMessage = string.Join("", newMessage);
            return finalMessage;

        }
    }
}