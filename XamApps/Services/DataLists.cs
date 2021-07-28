using System;
using System.Collections.Generic;
using XamApps.Models;

namespace XamApps.Services
{
    public class DataLists
    {
        public DataLists()
        {
            GetJsonData();
        }

        public List<Questions> GetJsonData()
        {
            QuestionList1 questionList1 = new QuestionList1();
            questionList1.QuestionList = new List<Questions>() {
                new Questions() {
                    QId=1,
                    Qkey="q1",
                    Qdesc="What is the capital of india ? ",
                    QType=1,
                    AnswerList = new System.Collections.ObjectModel.ObservableCollection<Answers>() {
                        new Answers() {
                            Akey = "a1",
                            Adesc = "capital 1"
                        },
                        new Answers() {
                            Akey = "a2",
                            Adesc = "capital 2"
                        },
                        new Answers() {
                            Akey = "a3",
                            Adesc = "capital 3"
                        }
                    }
                },
                new Questions() {
                    QId=2,
                    Qkey="q2",
                    Qdesc="Who is the president of US ?",
                    QType=1,
                    AnswerList = new System.Collections.ObjectModel.ObservableCollection<Answers>() {
                        new Answers() {
                            Akey = "a4",
                            Adesc = "president 1"
                        },
                        new Answers() {
                            Akey = "a5",
                            Adesc = "president 2"
                        },
                        new Answers() {
                            Akey = "a6",
                            Adesc = "president 3"
                        }
                    }
                },
                new Questions() {
                    QId=3,
                    Qkey="q3",
                    Qdesc="What is your favourite colour ?",
                    QType=1,
                    AnswerList = new System.Collections.ObjectModel.ObservableCollection<Answers>() {
                        new Answers() {
                            Akey = "a7",
                            Adesc = "Red"
                        },
                        new Answers() {
                            Akey = "a8",
                            Adesc = "Blue"
                        },
                        new Answers() {
                            Akey = "a9",
                            Adesc = "Black"
                        },
                        new Answers() {
                            Akey = "a10",
                            Adesc = "Orange"
                        },
                        new Answers() {
                            Akey = "a11",
                            Adesc = "Green"
                        }
                    }
                }
            };

            return questionList1.QuestionList;
        }
    }
}
