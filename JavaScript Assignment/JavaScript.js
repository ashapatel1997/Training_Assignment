/*jslint for:true*/
/*jslint getset:true*/
/*jslint browser:true*/
/*jslint devel:true*/
/*jslint white:true*/

var qualification = ["CE","IT","MCA","MBA"];
var experience = ["0 yr","1 yr","2 yrs","3 yrs"];
var coding_languages = [{LanguageName:"C/C++",IsEnabled:""},
                    {LanguageName:"Java",IsEnabled:"checked"},
                    {LanguageName:"C#",IsEnabled:"checked"},
                    {LanguageName:"PHP",IsEnabled:""},
                    {LanguageName:"Python",IsEnabled:""}];

//dropdown list for qualification
function getQualification()
{
    "use strict";
    var qua = document.getElementById("qualificationId");
    var i = 0;
    var qualification_option;
    while(i<qualification.length)
    {
        qualification_option=document.createElement("option");
        qualification_option.textContent=qualification[i];
        qualification_option.value=qualification[i];
        qua.appendChild(qualification_option);
        i+=1;
    }
}


function getExperience()
{
    "use strict";
    /*dropdown list for experience*/
    var exp=document.getElementById("experienceId");
    var i=0;
    var experience_option;
    while(i<experience.length)
    {
        experience_option=document.createElement("option");
        experience_option.textContent=experience[i];
        experience_option.value=experience[i];
        exp.appendChild(experience_option);
        i+=1;
    }
}

/*
    below logic is different than above.
    Because it was not working for checked=IsEnabled property.
*/
function getCodingLanguages()
{
    "use strict";
    var i=0;
    var title;
    var lang;
    var divElement;
    while(i<coding_languages.length)
    {
        title=coding_languages[i].LanguageName;
        divElement=document.createElement("div");
        if(i===1 || i===2)
        {
            lang=document.getElementById("codingLanguage");
            divElement.innerHTML="<input type='checkbox'  name="
            +title+" value="+title+" checked="+coding_languages[i].IsEnabled
            +" ><label for="+title+">"+title+"</label>";
            lang.appendChild(divElement);
        }
        else
        {
            lang=document.getElementById("codingLanguage");
            divElement.innerHTML="<input type='checkbox' name="
            +title+"value="+title+"><label for="
            +title+">"+title+"</label>";
            lang.appendChild(divElement);
        }
        i+=1;
    }
}

//display employee details
function display()
{
    "use strict";
    var selectedData={
        fnameField:"First Name:"
        +document.getElementById("firstName").value+"\n",
        lastNameField:"Last Name:"
        +document.getElementById("lastName").value+"\n",
        emailField:"Email Address:"
        +document.getElementById("email").value+"\n",
        contactNumberField:"Contact Number:"
        +document.getElementById("contactNumber").value+"\n",
        addressField:"Address:"
        +document.getElementById("address").value+"\n",
        userNameField:"User Name:"
        +document.getElementById("userName").value+"\n",
        passwordField:"Password:"
        +document.getElementById("passwd").value+"\n",
        qualificationField:"Qualification:"
        +document.getElementById("qualificationId")
        .options[document.getElementById("qualificationId")
        .selectedIndex].value+"\n",
        experienceField:"Experience:"
        +document.getElementById("experienceId")
        .options[document.getElementById("experienceId")
        .selectedIndex].value+"\n",
        //get selected Gender
        get displayGenderValue()
        {
            var genderField;
                if( document.getElementById("m1").checked===true)
                {
                    genderField=document.getElementById("m1").value;
                }
                else if(document.getElementById("m2").checked===true)
                {
                    genderField=document.getElementById("m2").value;
                }
                else
                {
                    genderField="";
                }
            return  "Gender:"+genderField+"\n";
        },
        //get selected Coding Languages
        get displayLanguageValue()
        {
            var checkedInput;
            checkedInput=document.getElementsByTagName("input");
            var codingLanguageField="";
            var i=0;
            while(i<checkedInput.length)
            {
                if(checkedInput[i].type==="checkbox"&& checkedInput[i]
                .checked===true)
                {
                codingLanguageField+=coding_languages[i-8].LanguageName+" ";
                }
                i+=1;
            }
            return "Coding Language:"+codingLanguageField+"\n";
        }
    };
    Object.keys(selectedData).forEach(function (key) {
        console.log(selectedData[key]);
    });
}

getQualification();
getExperience();
getCodingLanguages();



