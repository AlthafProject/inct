
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/login.css">
</head>
<body>
      
<form action="proses/PLogin.php" method="POST">
    <!-- Your form elements -->
    
    <div class='box'>
  <div class='box-form'>
    <div class='box-login-tab'></div>
    <div class='box-login-title'>
      <div class='i i-login'></div><h2>LOGIN</h2>
    </div>
    <div class='box-login'>
      <div class='fieldset-body' id='login_form'>
        <button onclick="openLoginInfo();" class='b b-form i i-more' title='Mais Informações'></button>
        	<p class='field'>
          <label for='user'>Kode Admin</label>
          <input type='text' id='kode_admin' name='kode_admin' title='kode_admin' />
          <span id='valida' class='i i-warning'></span>
        </p>
      	  <p class='field'>
          <label for='pass'>PASSWORD</label>
          <input type='password' id='pass' name='password' title='Password' />
          <span id='valida' class='i i-close'></span>
        </p>

          <label class='checkbox'>
            <input type='checkbox' value='TRUE' title='Keep me Signed in' /> Keep me Signed in
          </label>

        	<input type='submit' id='do_login' value='GET STARTED' title='Get Started' />
      </div>
    </div>
  </div>
</div>
</form>
</body>
</html>