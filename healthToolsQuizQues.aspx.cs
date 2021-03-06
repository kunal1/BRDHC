﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class healthToolsQuizQues : System.Web.UI.Page
{
    //variable to calculate the score and pageIndex
    public static int score = 0;
    public static int pageIndex = 0;

    //binding data on page load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            _subBind();
        }
    }

    protected void grid_page(object sender, GridViewPageEventArgs e)
    {
        //increases the pageIndex
        grid_quiz.PageIndex = pageIndex;
        _subBind();
    }

    //Events that occur when a user clicks the THIS button
    protected void btnThis_Click(object sender, EventArgs e)
    {
        int row = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;

        Panel PnlMpeThis = (Panel)grid_quiz.Rows[row].FindControl("pnl_mpeThis");
        HiddenField hdfThisAns = (HiddenField)PnlMpeThis.FindControl("hdf_thisAns");
        PnlMpeThis.Visible = true;

        Guid QuestionID = Guid.Parse(hdfThisAns.Value.ToString());

        //creating a new instance of the quizClass
        quizClass objLinq = new quizClass();

        //if THIS is the correct answer, display correct and increase the score
        if (objLinq.getAnswer(QuestionID).Equals("THIS"))
        {
            Label lbl_ans = (Label)PnlMpeThis.FindControl("lbl_ans");
            lbl_ans.Text = "Correct!";
            score += 1;
        }
        //if THAT is the answer, display sorry
        else
        {
            Label lbl_ans = (Label)PnlMpeThis.FindControl("lbl_ans");
            lbl_ans.Text = "Sorry!";
        }

    }

    //Events that occur when a user clicks the THAT button
    protected void btnThat_Click(object sender, EventArgs e)
    {
        int row = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;

        Panel PnlMpeThis = (Panel)grid_quiz.Rows[row].FindControl("pnl_mpeThis");
        HiddenField hdfThisAns = (HiddenField)PnlMpeThis.FindControl("hdf_thisAns");
        PnlMpeThis.Visible = true;

        Guid QuestionID = Guid.Parse(hdfThisAns.Value.ToString());

        quizClass objLinq = new quizClass();
        string Answer = objLinq.getAnswer(QuestionID).ToString();

        //if THAT is the correct answer, display correct and increase the score
        if (Answer.Equals("THAT"))
        {
            Label lbl_ans = (Label)PnlMpeThis.FindControl("lbl_ans");
            lbl_ans.Text = "Correct!";
            score += 1;
        }
        //if THIS is the answer, display sorry
        else
        {
            Label lbl_ans = (Label)PnlMpeThis.FindControl("lbl_ans");
            lbl_ans.Text = "Sorry!";
        }
    }
         
    //To move to the next question, or display the score
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (grid_quiz.PageIndex < grid_quiz.PageCount - 1 )
        {
            pnlQuiz.Visible = true;
            pnlResults.Visible = false;
            grid_quiz.PageIndex++;
            _subBind();
        }
        else
        {
            pnlQuiz.Visible = false;
            pnlResults.Visible = true;
            lblResults.Text = "Thank you for trying the Healthy Eating Quiz!<br /><br /> You scored " + score.ToString() + " out of " + grid_quiz.PageCount;
        }

    }

    //binding data to the GridView
    protected void _subBind()
    {
        quizClass objLinq = new quizClass();
        grid_quiz.DataSource = objLinq.getQues();
        grid_quiz.DataBind();
    }

}
