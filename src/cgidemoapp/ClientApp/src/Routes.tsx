import React from "react";
import { Route, Routes as Router } from "react-router-dom";
import Home from "./pages/index";
import NotFound from "./pages/404";

interface IRoutesProps {}

export const Routes: React.FC<IRoutesProps> = () => {
  return (
    <Router>
      <Route path={"/"} element={<Home />} />
      <Route element={<NotFound />} />
    </Router>
  );
};
