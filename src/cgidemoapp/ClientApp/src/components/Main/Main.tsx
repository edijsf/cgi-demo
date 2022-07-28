import React from "react";
import "./Main.css";

interface Props {
  children?: React.ReactNode;
}

const index = ({ children }: Props) => {
  return <div className="main">{children}</div>;
};

export default index;
