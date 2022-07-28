import React from "react";
import Header from "../Header";
import "./Page.css";

interface Props {
  children?: React.ReactNode;
}

const index = ({ children }: Props) => {
  return (
    <div className="page">
      <Header />
      <div className="page-body">{children}</div>
    </div>
  );
};

export default index;
