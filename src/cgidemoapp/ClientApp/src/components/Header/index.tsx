import React from "react";
import Logo from "./logo.png";
import Cart from "./cart.png";
import Search from "./search.png";
import Account from "./account.png";
import "./Header.css";

interface Props {}

const Header = (props: Props) => {
  return (
    <div className="header">
      <img src={Logo} alt="logo" />
      <div
        style={{
          marginLeft: "48px",
          paddingTop: "12px",
        }}
      >
        All Products
      </div>
      <div
        style={{
          marginLeft: "24px",
          paddingTop: "12px",
        }}
      >
        Trending
      </div>
      <div
        style={{
          marginLeft: "24px",
          paddingTop: "12px",
        }}
      >
        Stores
      </div>
      <div
        style={{
          marginLeft: "auto",
          paddingTop: "12px",
        }}
      >
        For Companies
      </div>
      <img
        className="header-icon"
        style={{
          marginLeft: "30px",
          paddingTop: "16px",
        }}
        src={Search}
        alt="search"
      />
      <img
        className="header-icon"
        style={{
          marginLeft: "30px",
          paddingTop: "16px",
        }}
        src={Account}
        alt="account"
      />
      <img
        className="header-icon"
        style={{
          marginLeft: "30px",
          paddingTop: "16px",
        }}
        src={Cart}
        alt="cart"
      />
    </div>
  );
};

export default Header;
