import React, { useState } from 'react';
import styles from './modal.module.css';
import close from '../../assets/img/close.png';

export default function Modal({ visible, setVisible, children }) {
  const classes = [styles.modalOuter];

  if (visible) {
    classes.push(styles.active);
  }

  return (
    <div onClick={() => setVisible(false)} className={classes.join(' ')}>
      <div onClick={(e) => e.stopPropagation()} className={styles.modalContent}>
        <button onClick={() => setVisible(false)}>
          <img src={require('../../assets/img/close.png')} alt="close"></img>
        </button>
        {children}
      </div>
    </div>
  );
}
