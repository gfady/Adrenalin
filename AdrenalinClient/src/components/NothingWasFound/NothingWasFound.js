import React from 'react';
import styles from './nothing.module.css';
import nothing from '../../assets/img/nothing_was_found.png';

export default function NothingWasFound() {
  return (
    <div className={styles.nothingWrapper}>
      <h2>По такому запросу ничего не найдено</h2>
      <img src={nothing}></img>
    </div>
  );
}
