
const arrThuongHieu = [
    {
        id: 1,
        img: "/Asset/img/1.png",
        des: "Đồng hồ nam",
        price: 20,
        url:"DongHoNam.aspx"
    },
    {
        id: 2,
        img: "/Asset/img/2.png",
        des: "Đồng hồ nữ",
        price: 30,
        url: "DongHoNu.aspx"
    },
    {
        id: 3,
        img: "/Asset/img/3.png",
        des: "Đồng hồ nam",
        price: 18,
        url: "DongHoNam.aspx"
    },
    {
        id: 4,
        img: "/Asset/img/4.png",
        des: "Đồng hồ Epos Swis",
        price: 100,
        url: "DongHoNam.aspx"
    },
    {
        id: 5,
        img: "/Asset/img/5.png",
        des: "Đồng hồ Thủy Điện",
        price: 200,
        url: "/DongHoNam.aspx"
    },
    {
        id: 6,
        img: "/Asset/img/10.png",
        des: "Đồng hồ Pháp",
        price: 70,
        url: "DongHoNu.aspx"
    },
    {
        id: 8,
        img: "/Asset/img/11.png",
        des: "Đồng hồ thủy điển",
        price: 50,
        url: "DongHoNu.aspx"
    },
    {
        id: 8,
        img: "/Asset/img/12.png",
        price: 18,
        des: "Đồng hồ Italy",
        url: "DongHoNu.aspx"
    },
    {
        id: 9,
        img: "/Asset/img/13.png",
        des: "Đồng hồ Anh",
        price: 20,
        url: "DongHoNu.aspx"
    }

]
let BananerItem = document.querySelector(".bananer")
let flexBox = document.querySelector(".flex-box");
let wrapImgs = document.querySelector(".wrap-imgs ");
let wraptText = document.querySelector(".wrap-text");


function displayWrapItem(wrapItem) {
    let displayWrap = wrapItem.map(function (item) {

        return `<div class="product">
                <a href="${item.url}">
                    <div class="wrap-img">
                        <img src="${item.img}" />
                    </div>
                    <div class="wrap-text">
                        ${item.des}
                    </div>
                </a>
            </div>`
    });

    displayWrap = displayWrap.join("");
    flexBox.innerHTML = displayWrap;
}

displayWrapItem(arrThuongHieu);

const arrProduct = [
    {
        id: 2,
        img: "/Asset/img/2.png",
        des: "Đồng hồ Italy",
        price: 10,
        url: "/DetailSubPage/"
    },
    {
        id: 3,
        img: "/Asset/img/3.png",
        des: "Đồng hồ Bỉ",
        price: 20,
        url: "/DetailSubPage/"
    },
    {
        id: 4,
        img: "/Asset/img/4.png",
        des: "Đồng hồ nam",
        price: 15,
        url: "/DetailSubPage/"
    },
    {
        id: 5,
        img: "/Asset/img/5.png",
        des: "Đồng hồ Epos Swis",
        price: 25,
        url: "/DetailSubPage/"
    },
    {
        id: 6,
        img: "/Asset/img/6.png",
        des: "Đồng hồ Thủy Điển",
        price: 100,
        url: "/DetailSubPage/"
    },
    {
        id: 7,
        img: "/Asset/img/9.png",
        des: "Đồng hồ Thủy Điển",
        price: 100,
        url: "/DetailSubPage/"
    }
]


// product

let productBox = document.querySelector(".product-box");
function displayProductItem(itemProduct) {

    let displayProduct = itemProduct.map((item) => { 

        return  `<div class="product-box-item">
                <a href="${item.url}">
                    <div class="product-img">
                        <img src="${item.img}" />
                    </div>
                </a>
                <a href="${item.url}">
                    <div class="product-des">
                        <div class="title">${item.des}</div>
                        <div class="price">
                            ${item.price}$ <i class="fa-solid fa-cart-shopping"></i>
                        </div>
                    </div>
                </a>
            </div>`
    });

    displayProduct = displayProduct.join("");
    productBox.innerHTML = displayProduct;
}


displayProductItem(arrThuongHieu);
