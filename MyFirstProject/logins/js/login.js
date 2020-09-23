$('#option li').click(function() {
	$(this).addClass('active').siblings().removeClass('active');
	var a = $(this).index();
	$('#card li:eq(' + a + ')').addClass('active').siblings().removeClass('active');
})

$(".icon_e").click(function() {
	$(".login_count_b").show();
	$(".login_count_a").hide();
})
$(".icon_z").click(function() {
	$(".login_count_a").show();
	$(".login_count_b").hide();
})

$("#btn").click(function () {
    var count = 60;
    var interval = setInterval(() => {
        if (count == 0) {
            $("#btn").val("重新获取").removeAttr("disabled");
            count = 60;
            clearTimeout(interval);
        } else {
            $("#btn").val(count + "s后重新获取").attr("disabled", "disabled");
            count--;
        }
    }, 1000);
})