using System;

// if I am being pedantic, I'm reversing a char[] (not a string)

namespace InterviewQuestions
{
    class ReverseWords
    {
        static void Main(string[] arguments)
        {
            string test = "Hello World this is a compound-word string";
            char[] test_characters = test.ToCharArray();
            Console.WriteLine(test_characters);
            reverse_string_words(ref test_characters);
            Console.WriteLine(test_characters);
        }
        
        // To reverse the words in a string like:
        // "The quick brown fox jumps over the lazy dog"
        // Reverse the words: "ehT kciuq nworb xof spmuj revo eht yzal god"
        // Reverse the entire string: "dog lazy the over jumps fox brown quick The"
        // These can be done in either order (you just have to be careful of logic errors and such).
        private static void reverse_string_words(ref char[] mutable_string)
        {
            int word_start = 0;
            int word_end = 0;
            while (word_start < mutable_string.Length) // reverse the words (NOTE: they will be gibberish)
            {
                if (Char.IsLetter(mutable_string[word_start])) // then we found a word to reverse
                {
                    word_end = word_start + 1;
                    while (word_end < mutable_string.Length && Char.IsLetter(mutable_string[word_end]))
                    {
                        word_end += 1;
                    }
                    word_end -= 1;
                    reverse_string(ref mutable_string, word_start, word_end);
                    word_start = word_end + 1;
                }
                word_start += 1;
            }
            reverse_string(ref mutable_string); // then reverse the string
        }
        
        private static void reverse_string(ref char[] mutable_string, int forward_iterator, int backward_iterator)
        {
            while (forward_iterator < backward_iterator)
            {
                char swapper = mutable_string[forward_iterator];
                mutable_string[forward_iterator] = mutable_string[backward_iterator];
                mutable_string[backward_iterator] = swapper;
                
                forward_iterator += 1;
                backward_iterator -= 1;
            }
        }
        
        private static void reverse_string(ref char[] mutable_string)
        {
            reverse_string(ref mutable_string, 0, mutable_string.Length - 1);
        }
    }
}
