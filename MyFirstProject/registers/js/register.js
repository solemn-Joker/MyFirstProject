function register() {
    var password = document.getElementById('register-password-first').value;
    var repassword = document.getElementById('register-password-affirm').value;
    var form = document.getElementById("filter_all");
    if (password == "" && repassword == "") {
        return false;
    }
    else if (password != repassword) {
        alert("两次密码输入不一致！");
        return false;
    }
    else {
        form.submit();
        alert("提交OK");
        return true;
    }
}