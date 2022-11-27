/* Set rates + misc */
var taxRate = 0.05;
var shippingRate = 15.0;
var fadeTime = 300;
var subtotal = 0;

/* Assign actions */
$(".products-quantity input").change(function () {
    updateQuantity(this);
});

$(".products-removal button").click(function () {
    removeItem(this);
});

/* Recalculate cart */
function recalculateCart() {

    /* Sum up row totals */
    $(".products").each(function () {
        subtotal += parseFloat($(this).children(".products-line-price").text());
    });

    /* Calculate totals */
    var tax = subtotal * taxRate;
    var shipping = subtotal > 0 ? shippingRate : 0;
    var total = subtotal + tax + shipping;

    /* Update totals display */
    $(".totals-value").fadeOut(fadeTime, function () {
        $("#cart-subtotal").html(subtotal.toFixed(2));
        $("#cart-tax").html(tax.toFixed(2));
        $("#cart-shipping").html(shipping.toFixed(2));
        $("#cart-total").html(total.toFixed(2));
        if (total == 0) {
            $(".checkout").fadeOut(fadeTime);
        } else {
            $(".checkout").fadeIn(fadeTime);
        }
        $(".totals-value").fadeIn(fadeTime);
    });
}

/* Update quantity */
function updateQuantity(quantityInput) {
    /* Calculate line price */
    var productsRow = $(quantityInput).parent().parent();
    var price = parseFloat(productsRow.children(".products-price").text());
    var quantity = $(quantityInput).val();
    var linePrice = price * quantity;

    /* Update line price display and recalc cart totals */
    productsRow.children(".products-line-price").each(function () {
        $(this).fadeOut(fadeTime, function () {
            $(this).text(linePrice.toFixed(2));
            recalculateCart();
            $(this).fadeIn(fadeTime);
        });
    });
}

/* Remove item from cart */
function removeItem(removeButton) {
    /* Remove row from DOM and recalc cart total */
    var productsRow = $(removeButton).parent().parent();
    productsRow.slideUp(fadeTime, function () {
        productsRow.remove();
        recalculateCart();
       
    });
}

