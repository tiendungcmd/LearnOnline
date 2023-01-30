using LearnOnline.API.Data;
using LearnOnline.API.Services.QuestionService;
using LearnOnline.Models;
using LearnOnline.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LearnOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly LearnOnlineDbContext _learnOnlineDb;

        public QuestionController(IQuestionService questionService, LearnOnlineDbContext learnOnlineDb)
        {
            _questionService = questionService;
            _learnOnlineDb = learnOnlineDb;
        }
        [HttpGet("{partId}")]
        public ActionResult<ServiceResponse<AnswerDto>> GetByPartId(int partId)
        {
            var resulst = _learnOnlineDb.Question.Where(x => x.PartId == partId);
            var result = addQuestion(resulst.ToList());
            return Ok(result);
        }
        [HttpPost]
        public ActionResult<ServiceResponse<Question>> CreateQuestion(AnswerDto answerDto)
        {
            Add(answerDto);
            _learnOnlineDb.SaveChanges();
            return Ok();
        }
        [HttpDelete("{Id}")]
        public ActionResult DeleteCategory(int Id)
        {
            var ques = _learnOnlineDb.Question.Where(x => x.PartId == Id).ToList();
            foreach (var item in ques)
            {
                _learnOnlineDb.Question.Remove(item);
            }
            _learnOnlineDb.SaveChanges();
            return Ok();
        }
        private void Add(AnswerDto answerDto)
        {
            var questionPart = _learnOnlineDb.Question.FirstOrDefault(x => x.PartId == answerDto.PartId);
            for (int i = 1; i <= 40; i++)
            {
                var answer = new Question();
                var ques = new Question();
                answer.PartId = answerDto.PartId;
                answer.Content = i.ToString();
                var Content = _learnOnlineDb.Question.FirstOrDefault(x => x.Content == i.ToString());
                switch (answer.Content)
                {
                    case "1":
                        answer.Result = answerDto.Result1;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "2":
                        answer.Result = answerDto.Result2;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "3":
                        answer.Result = answerDto.Result3;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "4":
                        answer.Result = answerDto.Result4;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "5":
                        answer.Result = answerDto.Result5;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "6":
                        answer.Result = answerDto.Result6;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "7":
                        answer.Result = answerDto.Result7;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "8":
                        answer.Result = answerDto.Result8;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "9":
                        answer.Result = answerDto.Result9;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "10":
                        answer.Result = answerDto.Result10;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "11":
                        answer.Result = answerDto.Result11;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "12":
                        answer.Result = answerDto.Result12;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "13":
                        answer.Result = answerDto.Result13;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "14":
                        answer.Result = answerDto.Result14;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "15":
                        answer.Result = answerDto.Result15;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "16":
                        answer.Result = answerDto.Result16;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "17":
                        answer.Result = answerDto.Result17;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "18":
                        answer.Result = answerDto.Result18;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "19":
                        answer.Result = answerDto.Result19;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "20":
                        answer.Result = answerDto.Result20;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "21":
                        answer.Result = answerDto.Result21;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "22":
                        answer.Result = answerDto.Result22;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "23":
                        answer.Result = answerDto.Result23;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "24":
                        answer.Result = answerDto.Result24;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "25":
                        answer.Result = answerDto.Result25;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "26":
                        answer.Result = answerDto.Result26;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "27":
                        answer.Result = answerDto.Result27;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "28":
                        answer.Result = answerDto.Result28;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "29":
                        answer.Result = answerDto.Result29;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "30":
                        answer.Result = answerDto.Result30;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "31":
                        answer.Result = answerDto.Result31;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "32":
                        answer.Result = answerDto.Result32;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "33":
                        answer.Result = answerDto.Result33;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "34":
                        answer.Result = answerDto.Result34;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "35":
                        answer.Result = answerDto.Result35;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "36":
                        answer.Result = answerDto.Result36;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "37":
                        answer.Result = answerDto.Result37;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "38":
                        answer.Result = answerDto.Result38;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "39":
                        answer.Result = answerDto.Result39;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                    case "40":
                        answer.Result = answerDto.Result40;
                        ques = FindQuenstion(answer.Content, answer.PartId);
                        if (ques != null)
                        {
                            ques.Result = answer.Result;
                            _learnOnlineDb.Question.Update(ques);
                        }
                        else
                        {
                            if (answer.Result != "")
                            {
                                _learnOnlineDb.Question.Add(answer);
                            }
                        }
                        _learnOnlineDb.SaveChanges();
                        break;
                }
            }
        }
        private Question FindQuenstion(string content, int partId)
        {
            var ques = _learnOnlineDb.Question.FirstOrDefault(x => x.Content == content && x.PartId == partId);
            return ques;
        }
        //return answerDto
        private AnswerDto addQuestion(List<Question> questions)
        {
            var answerDto = new AnswerDto();
            for (int i = 1; i <= 40; i++)
            {
                var question = new Question();
                var x = questions.FirstOrDefault(x => x.Content == i.ToString());
                if (x != null)
                {
                    switch (int.Parse(x.Content))
                    {
                        case 1:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result1 = question.Result;
                            break;
                        case 2:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result2 = question.Result;
                            break;
                        case 3:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result3 = question.Result;
                            break;
                        case 4:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result4 = question.Result;
                            break;
                        case 5:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result5 = question.Result;
                            break;
                        case 6:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result6 = question.Result;
                            break;
                        case 7:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result7 = question.Result;
                            break;
                        case 8:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result8 = question.Result;
                            break;
                        case 9:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result9 = question.Result;
                            break;
                        case 10:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result10 = question.Result;
                            break;
                        case 11:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result11 = question.Result;
                            break;
                        case 12:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result12 = question.Result;
                            break;
                        case 13:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result13 = question.Result;
                            break;
                        case 14:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result14 = question.Result;
                            break;
                        case 15:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result15 = question.Result;
                            break;
                        case 16:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result16 = question.Result;
                            break;
                        case 17:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result17 = question.Result;
                            break;
                        case 18:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result18 = question.Result;
                            break;
                        case 19:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result19 = question.Result;
                            break;
                        case 20:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result20 = question.Result;
                            break;
                        case 21:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result21 = question.Result;
                            break;
                        case 22:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result22 = question.Result;
                            break;
                        case 23:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result23 = question.Result;
                            break;
                        case 24:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result24 = question.Result;
                            break;
                        case 25:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result25 = question.Result;
                            break;
                        case 26:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result26 = question.Result;
                            break;
                        case 27:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result27 = question.Result;
                            break;
                        case 28:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result28 = question.Result;
                            break;
                        case 29:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result29 = question.Result;
                            break;
                        case 30:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result30 = question.Result;
                            break;
                        case 31:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result31 = question.Result;
                            break;
                        case 32:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result32 = question.Result;
                            break;
                        case 33:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result33 = question.Result;
                            break;
                        case 34:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result34 = question.Result;
                            break;
                        case 35:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result35 = question.Result;
                            break;
                        case 36:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result36 = question.Result;
                            break;
                        case 37:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result37 = question.Result;
                            break;
                        case 38:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result38 = question.Result;
                            break;
                        case 39:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result39 = question.Result;
                            break;
                        case 40:
                            question = questions.FirstOrDefault(x => x.Content == i.ToString());
                            answerDto.Result40 = question.Result;
                            break;
                    }
                }

            }
            return answerDto;
        }
    }
}
