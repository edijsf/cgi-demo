import React from "react";
import "./Sidebar.css";

interface Props {
  children?: React.ReactNode;
}

const index = ({ children }: Props) => {
  return <div className="sidebar">{children}</div>;
};

export default index;
